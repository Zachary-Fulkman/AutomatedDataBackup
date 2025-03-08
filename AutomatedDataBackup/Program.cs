using System;
using System.Windows.Forms;
using AutomatedDataBackupUI;

namespace AutomatedDataBackup
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            var logger = new BackupLog();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            logger.LogBackup("Backup created.");
        }
    }
}
