using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Windows.UI.Notifications;
using Windows.Data.Xml.Dom;


namespace PPE3_CodeMatters_Github
{

    public partial class FormMenu : Form
    {

        string gsb = "Galaxy Swiss Bourdin - ";

        public FormMenu()
        {
            InitializeComponent();
        }

        private void GestionDesComptesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGCR open = new FormGCR();
            open.FormBorderStyle = FormBorderStyle.None;
            open.TopLevel = false;
            panel1.Controls.Add(open);         
            open.Show();
        }

        private void QuitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConnexion ouverture = new FormConnexion();
            this.Hide();
            ouverture.ShowDialog();
        }

        private void GestionDesVisiteursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*FormVisiteur open = new FormVisiteur();
            open.FormBorderStyle = FormBorderStyle.None;
            open.TopLevel = false;
            panel1.Controls.Add(open);
            open.Show();*/
            FormVisiteur open = new FormVisiteur();
            open.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            bsNom.DataSource = Modele.ViConnecte();
        }

        private string welcomeMessage()
        {
            var random = new Random();
            List<string> welcome = new List<string>() { " se joint à la fête.", " est dans la place.", " vient d'attérir.", ", laissez vos armes à l'entrée.", " est là."
            , ", nous vous attendions ° ͜ʖ ͡°", "Tiens, toi, oui toi "};
            int index = random.Next(welcome.Count);

            return welcome[index];
        }

        private string randomHello()
        {
            var random = new Random();
            List<string> hello = new List<string>() { "Hey ", "Bonjour ", "Bienvenue " };
            int index = random.Next(hello.Count);

            return hello[index];
        }

        private void bsNom_CurrentChanged(object sender, EventArgs e)
        {
            string name = ((Visiteur)bsNom.Current).nom;
            string firstName = ((Visiteur)bsNom.Current).prenom;
            if(welcomeMessage() == ", laissez vos armes à l'entrée." || welcomeMessage() == ", nous vous attendions ° ͜ʖ ͡°")
            {
                this.Text = gsb + randomHello() + name + " " + firstName + welcomeMessage();
            }
            else if (welcomeMessage() == "Tiens, toi, oui toi ")
            {
                this.Text = gsb + welcomeMessage() + name + " " + firstName + ", tu nous as manqué tu sais ?";
            }
            else
            {
                this.Text = gsb + name + " " + firstName + welcomeMessage();
            }
            
        }
    }
}
