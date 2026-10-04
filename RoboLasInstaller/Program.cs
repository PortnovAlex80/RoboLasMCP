using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace RoboLasInstaller
{

static class Program
{
    [STAThread]
    static void Main(string[] args)
    {
        // Check if running as admin
        if (!IsRunningAsAdmin())
        {
            // Restart with admin rights
            var processInfo = new ProcessStartInfo
            {
                FileName = Process.GetCurrentProcess().MainModule?.FileName ?? Application.ExecutablePath,
                UseShellExecute = true,
                Verb = "runas",
                Arguments = args.Length > 0 ? "\"" + args[0] + "\"" : ""
            };

            try
            {
                Process.Start(processInfo);
            }
            catch
            {
                // User declined UAC
                MessageBox.Show(
                    "Для установки требуется права администратора.",
                    "RoboLas Installer",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            return;
        }

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new MainForm(args));
    }

    static bool IsRunningAsAdmin()
    {
        using var identity = System.Security.Principal.WindowsIdentity.GetCurrent();
        var principal = new System.Security.Principal.WindowsPrincipal(identity);
        return principal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator);
    }
}

}
