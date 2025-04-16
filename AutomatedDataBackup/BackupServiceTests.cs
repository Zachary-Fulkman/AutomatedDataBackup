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
    public class BackupServiceTests
    {
        [Fact]
        public void BackupData_SuccessfulBackup_WritesLog()
        {
            // Arrange
            var logger = new BackupLog();
            var backupService = new BackupService(logger);
            string sourceDirectory = @"C:\TestData"; // Simulated test directory
            string backupDirectory = @"D:\Backup";
            string logFilePath = Path.Combine(Directory.GetCurrentDirectory(), "BackupLog.txt");

            // Make sure the test directory exists
            Directory.CreateDirectory(sourceDirectory);

            // Act
            backupService.BackupData(sourceDirectory, backupDirectory);

            // Assert
            string logContents = File.ReadAllText(logFilePath);
            Assert.Contains("Backup completed.", logContents);

            // Clean up
            Directory.Delete(sourceDirectory, true);
            File.Delete(logFilePath);
        }
    }
}
