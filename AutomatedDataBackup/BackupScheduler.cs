using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomatedDataBackupUI;

namespace AutomatedDataBackup
{
    class BackupScheduler
    {
        private System.Timers.Timer _timer;
        private BackupService _backupService;

        public BackupScheduler(BackupLog logger)
        {
            _backupService = new BackupService(logger);
            _timer = new System.Timers.Timer(3600000);
            _timer.Elapsed += OnElapsedTime;
            _timer.AutoReset = true;
        }

        // Calls method when timer ends
        private void OnElapsedTime(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Running backup...");

            // Calls the Backup Data method from the BackupService class
            _backupService.BackupData(@"C:BusinessData", @"D:\Backup");
        }
        public void Start() => _timer.Start();
        public void Stop() => _timer.Stop();
    }
}
