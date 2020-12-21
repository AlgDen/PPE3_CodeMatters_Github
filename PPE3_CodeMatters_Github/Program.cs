using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE3_CodeMatters_Github
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Sample comments added in the branch you can delete
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Modele.init();

            var toast_window = ToastWindow.Instance;

            Application.Run(new FormConnexion());
        }
    }
}
