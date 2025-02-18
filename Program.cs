using System;

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
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            // Application app = new Application();
            // app.IsMdiContainer = true;

            //Forms.ClientUpdaterForm app = new Forms.ClientUpdaterForm();
            //Forms.ProfileForm app = new Forms.ProfileForm();
            Forms.AutoPatcher app = new Forms.AutoPatcher();
            System.Windows.Forms.Application.Run(app);
        }
    }
}
