using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using AutomatedDataBackupUI;


namespace AutomatedDataBackupUI
{
    public class BackupLogTests
    {
        [Fact]
        public void LogBackup_Message_AppendsToLogFile()
        {
            // Arrange
            var logFilePath = Path.Combine(Directory.GetCurrentDirectory(), "BackupLog.txt");
            var backupLog = new BackupLog(logFilePath);

            // Act
            backupLog.LogBackup("Backup started.");

            // Assert
            string logContents = File.ReadAllText(logFilePath);
            Assert.Contains("Backup started.", logContents);

            // Clean up
            File.Delete(logFilePath);
        }

        [Fact]
        public void LogBackup_CreatesLogFile_WhenNotExists()
        {
            // Arrange
            var logFilePath = Path.Combine(Directory.GetCurrentDirectory(), "BackupLogTest.txt");
            var backupLog = new BackupLog(logFilePath);

            // Act
            backupLog.LogBackup("Backup created.");

            // Assert
            Assert.True(File.Exists(logFilePath));  // Log file should be created

            // Clean up
            File.Delete(logFilePath);
        }
    }
}
