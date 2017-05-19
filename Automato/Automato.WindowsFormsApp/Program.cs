using Automato.App.Domain.Services;
using Automato.App.Services;
using System;
using System.Windows.Forms;

namespace Automato.WindowsFormsApp
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
            Application.Run(new Form1(
                new AutomataService(),
                new WordService(),
                new ResultService())
            );
        }
    }
}
