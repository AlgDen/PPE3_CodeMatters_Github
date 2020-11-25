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
            bsVisiteur.DataSource = Modele.ViConnecte();
            
        }

        private void BsVisiteur_CurrentChanged(object sender, EventArgs e)
        {
            txtNom.Text = ((Visiteur)bsVisiteur.Current).nom;
            txtPrenom.Text = ((Visiteur)bsVisiteur.Current).prenom;
            txtRue.Text = ((Visiteur)bsVisiteur.Current).rue;
            txtCP.Text = ((Visiteur)bsVisiteur.Current).cp;
            txtVille.Text = ((Visiteur)bsVisiteur.Current).ville;
            txtEmbauche.Text = ((Visiteur)bsVisiteur.Current).dateEmbauche;
            bsTravailRegion.DataSource = ((Visiteur)bsVisiteur.Current).Region1.ToList(); // travail dans région
            dgvResponsabilite.DataSource = bsTravailRegion;

            bsResRegion.DataSource = ((Visiteur)bsVisiteur.Current).Region.ToList(); // responsable région
            dgvResRegion.DataSource = bsResRegion;

            for (int i=0; i<dgvResponsabilite.ColumnCount; i++)
            {
                dgvResponsabilite.Columns[i].Visible = false;
            }

            if(dgvResponsabilite.Rows.Count == 0)
            {
                dgvResponsabilite.Visible = false;
                
            }
            else
            {
                lblTravail.Text = "Vous travaillez dans les régions suivantes : ";
                dgvResponsabilite.Columns["idRegion"].Visible = true;
                dgvResponsabilite.Columns["idRegion"].HeaderText = "Num Région";
                dgvResponsabilite.Columns["idRegion"].DisplayIndex = 0;

                dgvResponsabilite.Columns["libRegion"].Visible = true;
                dgvResponsabilite.Columns["libRegion"].HeaderText = "Région";
                dgvResponsabilite.Columns["libRegion"].DisplayIndex = 0;
            }

            for (int i = 0; i < dgvResRegion.ColumnCount; i++)
            {
                dgvResponsabilite.Columns[i].Visible = false;
            }

            if (dgvResRegion.Rows.Count > 0)
            {
                linklblResRegion.Text = "Vous êtes également responsable des régions suivantes : ";
                linklblResRegion.Visible = true;
            }
            



            
            


        }

        private void BtnModif_Click(object sender, EventArgs e)
        {
            // DEVIENT FALSE
            btnModif.Visible = false;
            btnModifMDP.Visible = false;

            // DEVIENT TRUE
            btnValiderModif.Visible = true;
            btnAnnuler.Visible = true;

            txtNom.Enabled = true;
            txtPrenom.Enabled = true;
            txtRue.Enabled = true;
            txtEmbauche.Enabled = false;
            txtCP.Enabled = true;
            txtVille.Enabled = true;
        }

        private void BtnValiderModif_Click(object sender, EventArgs e)
        {
            if(Modele.ModifVisiteur(txtNom.Text, txtPrenom.Text, txtRue.Text, txtCP.Text, txtVille.Text, txtEmbauche.Text))
            {
                lblNotif.Text="Les modifications ont été enregistrées.";
                lblNotif.BackColor = Color.Green;
                MessageBox.Show(lblNotif.Text, "Modification", MessageBoxButtons.OK);
                
                // DEVIENT TRUE
                btnModif.Visible = true;
                btnModifMDP.Visible = true;

                // DEVIENT FALSE
                btnValiderModif.Visible = false;
                btnAnnuler.Visible = false;

                txtNom.Enabled = false;
                txtPrenom.Enabled = false;
                txtRue.Enabled = false;
                txtCP.Enabled = false;
                txtVille.Enabled = false;
            }
            else
            {
                MessageBox.Show("Erreur dans la modification.", "Modification", MessageBoxButtons.OK);
            }
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            // DEVIENT TRUE
            btnModif.Visible = true;
            btnModifMDP.Visible = true;

            // DEVIENT FALSE
            btnValiderModif.Visible = false;
            btnAnnuler.Visible = false;

            txtNom.Enabled = false;
            txtPrenom.Enabled = false;
            txtRue.Enabled = false;
            txtCP.Enabled = false;
            txtVille.Enabled = false;

            txtNom.Text = ((Visiteur)bsVisiteur.Current).nom;
            txtPrenom.Text = ((Visiteur)bsVisiteur.Current).prenom;
            txtRue.Text = ((Visiteur)bsVisiteur.Current).rue;
            txtCP.Text = ((Visiteur)bsVisiteur.Current).cp;
            txtVille.Text = ((Visiteur)bsVisiteur.Current).ville;
            txtEmbauche.Text = ((Visiteur)bsVisiteur.Current).dateEmbauche;
        }

        private void BtnModifMDP_Click(object sender, EventArgs e)
        {
            FModifMDP open = new FModifMDP();
            open.Show();
        }


    }
}
