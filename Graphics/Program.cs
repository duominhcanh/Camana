using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;

namespace Graphics
{
    public static class Program
    {
        public static Users us = new Users();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmDash dash = new frmDash();
            Application.Run(dash);
        }
    }
}
