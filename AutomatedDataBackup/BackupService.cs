using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedDataBackup
{
    class BackupService
    {
        //Backs up data from a source directory to a destination directory
        public void BackupData(string sourceDirectory, string backupDirectory)
        {
            try
            {
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

                        Console.WriteLine($"Backed up {file} to {destinationPath}");
                    }
                }
                else
                {
                    Console.WriteLine("Source directory does not exist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during backup: {ex.Message}");
            }
        }
    }
}
