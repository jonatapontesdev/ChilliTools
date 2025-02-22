using System;
using System.Windows.Forms;
using JPRagTools.Utils;

namespace JPRagTools
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (Forms.LoginForm loginForm = new Forms.LoginForm())
            {
                loginForm.ShowDialog();

                if (loginForm.IsAuthenticated)
                {
                    Application.Run(new Forms.AutoPatcher());
                }
            }
        }
    }
}