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

        private bool fermeture = false;

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
            if (fermeture) return;

            
            dgvVisiteur.ColumnCount = 6;
            dgvVisiteur.ColumnHeadersVisible = true;

            dgvVisiteur.Columns[0].Name = "Nom";
            dgvVisiteur.Columns[1].Name = "Prénom";
            dgvVisiteur.Columns[2].Name = "Rue";
            dgvVisiteur.Columns[3].Name = "CP";
            dgvVisiteur.Columns[4].Name = "Ville";
            dgvVisiteur.Columns[5].Name = "Date Embauche";

            bsVisiteur.DataSource = Modele.listeVisiteur();
            dgvVisiteur.DataSource = bsVisiteur;
        }
    }
}
