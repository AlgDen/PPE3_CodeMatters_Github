using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PPE3_CodeMatters_Github
{
    public partial class FormVisiteur : Form
    {
        public FormVisiteur()
        {
            InitializeComponent();
        }

        private void FormVisiteur_Load(object sender, EventArgs e)
        {
            bsVisiteur.DataSource = Modele.listeVisiteur();
        }

        private void BsVisiteur_CurrentChanged(object sender, EventArgs e)
        {
            lblNom.Text = ((Visiteur)bsVisiteur.Current).nom;
            lblPrenom.Text = ((Visiteur)bsVisiteur.Current).prenom;
            lblVille.Text = ((Visiteur)bsVisiteur.Current).ville;
            lblCP.Text = ((Visiteur)bsVisiteur.Current).cp;
            lblNom.Text = ((Visiteur)bsVisiteur.Current).nom;
            lblRue.Text = ((Visiteur)bsVisiteur.Current).rue;
            lblEmbauche.Text = ((Visiteur)bsVisiteur.Current).dateEmbauche;

        }
    }
}
