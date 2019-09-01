using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using eBusStation.Desktop.Properties;

namespace eBusStation.Desktop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string username = Settings.Default.username;

            if (string.IsNullOrEmpty(username))
                Application.Run(new LoginForm());
            else
                Application.Run(new MainForm());
        }
    }
}
