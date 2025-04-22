using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedDataBackupUI
{
    public static class PythonRunner
    {
        public static void Run(string scriptPath, string arguments = "")
        {
            var psi = new ProcessStartInfo
            {
                FileName = "python",
                Arguments = $"\"{scriptPath}\" {arguments}",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            using (var process = Process.Start(psi))
            {
                string output = process.StandardOutput.ReadToEnd();
                string errors = process.StandardError.ReadToEnd();
                process.WaitForExit();

                Debug.WriteLine("Python Output: " + output);
                if (!string.IsNullOrWhiteSpace(errors))
                    Debug.WriteLine("Python Errors: " + errors);
            }
        }
    }
}
