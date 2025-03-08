using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedDataBackupUI
{
    public class BackupLog
    {
        private readonly string logFilePath;

        public BackupLog(string? logFilePath = null)
        {
            string userDocumentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            this.logFilePath = logFilePath ?? Path.Combine(userDocumentsFolder, "BackupLogs", "BackupLog.txt");

            // Ensures the directory exists
            string? directoryPath = Path.GetDirectoryName(this.logFilePath);
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath); // Create the directory if it doesn't exist
                Console.WriteLine($"Directory created: {directoryPath}");
            }


            if (!File.Exists(this.logFilePath))
            {
                File.Create(this.logFilePath).Dispose();
                Console.WriteLine($"Log file created: {this.logFilePath}");
            }
        }
        public void LogBackup(string message)
        {
            try
            {
                string logMessage = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss}: {message}";
                File.AppendAllText(this.logFilePath, logMessage + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing log: {ex.Message}");
            }
        }
    }
}
