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

            ToastWindow.Instance.ShowNotification(
                "Deni le boss", 
                "c'est moi le boss", 
                "depuis l'extérieur", 
                @"C:\Users\denia\Source\Repos\PPE3_CodeMatters_Github\PPE3_CodeMatters_Github\Resources\Untitled-11.png"
            );


            Application.Run(new FormConnexion());
        }
    }
}
