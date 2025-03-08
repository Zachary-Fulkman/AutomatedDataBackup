using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomatedDataBackupUI;

namespace AutomatedDataBackup
{
    class BackupService
    {
        // Adding Logs
        private readonly BackupLog _logger;
        public BackupService(BackupLog logger)
        {
            _logger = logger;
        }

        //Backs up data from a source directory to a destination directory + Log Operation
        public void BackupData(string sourceDirectory, string backupDirectory)
        {
            try
            {
                _logger.LogBackup("Backup started.");

                // Tries to check if a source directory exists
                if (Directory.Exists(sourceDirectory))
                {
                    // Creates a backup directory if not
                    if (!Directory.Exists(backupDirectory))
                    {
                        Directory.CreateDirectory(backupDirectory); // Creates the directory
                    }

                    // Gets files from the source directory
                    var files = Directory.GetFiles(sourceDirectory);

                    foreach (var file in files)
                    {
                        string destinationPath = Path.Combine(backupDirectory, Path.GetFileName(file));

                        //Copies file to the backup
                        File.Copy(file, destinationPath, overwrite: true);

                        _logger.LogBackup($"Backed up {file} to {destinationPath}");
                    }
                    _logger.LogBackup("Backup Completed successfully.");
                }
                else
                {
                    _logger.LogBackup("Source directory does not exist.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogBackup($"Error during backup: {ex.Message}");
            }
        }
    }
}
