using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using AutomatedDataBackupUI;
using AutomatedDataBackup;

namespace AutomatedDataBackupUI
{
    public class BackupSchedulerTests
    {
        [Fact]
        public void Start_ValidatesIfSchedulerStarts()
        {
            // Arrange
            var logger = new BackupLog();
            var backupScheduler = new BackupScheduler(logger);
            bool timerStarted = false;

            // Act
            backupScheduler.Start();

            // Simulate some waiting time for the timer to tick
            Thread.Sleep(1000);  // Sleep for 1 second to allow the timer to start

            // Assuming you have a method to check if the scheduler is running
            timerStarted = backupScheduler.IsRunning();  // You may need to implement this method

            // Assert
            Assert.True(timerStarted);
        }

        [Fact]
        public void Stop_ValidatesIfSchedulerStops()
        {
            // Arrange
            var logger = new BackupLog();
            var backupScheduler = new BackupScheduler(logger);

            // Act
            backupScheduler.Start();  // Start the scheduler
            backupScheduler.Stop();   // Stop it immediately

            // Simulate a short delay for the stop to take effect
            Thread.Sleep(500);

            // Assuming you have a method to check if the scheduler is running
            bool timerStopped = backupScheduler.IsRunning();  // You may need to implement this method

            // Assert
            Assert.False(timerStopped);
        }
    }
}
