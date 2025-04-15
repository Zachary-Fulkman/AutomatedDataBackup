using System;
using System.Windows.Forms;
using AutomatedDataBackup;


namespace AutomatedDataBackupUI
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer _backupTimer;
        private DateTime _scheduledBackupTime;
        private BackupScheduler _backupScheduler;
        private BackupLog _logger;

        public Form1()
        {
            InitializeComponent();
            _logger = new BackupLog();
            _backupScheduler = new BackupScheduler(_logger);
            _backupScheduler.Start();

            //Fixed double DateTimePicker

            // Set range for days of week (0 = Sunday, 6 = Saturday)
numericUpDownDayOfWeek.Minimum = 0;
numericUpDownDayOfWeek.Maximum = 6;
numericUpDownDayOfWeek.Value = 1; // Default to Monday

// Set range for days of month (1–31)
numericUpDownDayOfMonth.Minimum = 1;
numericUpDownDayOfMonth.Maximum = 31;
numericUpDownDayOfMonth.Value = 1; // Default to 1st of the month

            _backupTimer = new System.Windows.Forms.Timer();
            _backupTimer.Interval = 60000; // Check every minute
            _backupTimer.Tick += BackupTimer_Tick;
        }

        private void BackupTimer_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now >= _scheduledBackupTime)
            {
                StartBackup();
                _backupTimer.Stop();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _scheduledBackupTime = dateTimePickerTime.Value;
            _backupTimer.Start();
            lblStatus.Text = "Backup scheduled for " + _scheduledBackupTime.ToString("HH:mm");
        }

        private void StartBackup()
        {
            lblStatus.Text = "Starting backup...";
            BackupService backupService = new BackupService(_logger);
            backupService.BackupData(@"C:\BusinessData", @"D:\Backup");
            lblStatus.Text = "Backup completed.";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Stopping periodic backup...";
            _backupScheduler.Stop();  // Stops the periodic backup
            lblStatus.Text = "Periodic backup stopped.";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _backupTimer.Stop();
            lblStatus.Text = "Scheduled backup cancelled.";
        }
    }
}
