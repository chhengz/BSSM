using bookshopsystem.Forms;
using bookshopsystem.Models;
using bookshopsystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookshopsystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new LoginForm());

            //Application.Run(new StaffsList());
            //Application.Run(new BooksList());
            //Application.Run(new MainForm());

            //Application.Run(new ReportsForm());
        }
    }
}
