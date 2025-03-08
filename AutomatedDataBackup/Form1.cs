using System;
using System.Windows.Forms;
using AutomatedDataBackup;


namespace AutomatedDataBackupUI
{
    public partial class Form1 : Form
    {
        private BackupScheduler _backupScheduler;
        private BackupLog _logger;

        public Form1()
        {
            InitializeComponent();
            _logger = new BackupLog();
            _backupScheduler = new BackupScheduler(_logger);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Stopping backup...";
            _backupScheduler.Stop();
            lblStatus.Text = "Backup stopped.";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Starting backup...";
            _backupScheduler.Start();
            lblStatus.Text = "Backup started.";
        }
    }
}
