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
            bsTravailRegion.DataSource = ((Visiteur)bsVisiteur.Current).Region1.ToList(); // travaille dans région
            dgvResponsabilite.DataSource = bsTravailRegion;

            bsResRegion.DataSource = ((Visiteur)bsVisiteur.Current).Region.ToList(); // est responsable de région
            dgvResRegion.DataSource = bsResRegion;

            bsResSecteur.DataSource = ((Visiteur)bsVisiteur.Current).Secteur.ToList(); // est responsable de secteur
            dgvResSecteur.DataSource = bsResSecteur;

            // Si le binding source n'est pas empty
            if (bsResSecteur.Count > 0)
            {
                ShowResSecteur();
            }
            else if (bsTravailRegion.Count > 0 && bsResRegion.Count == 0)
            {
                ShowWorkRegion();
            }
            else if (bsResRegion.Count > 0 && bsResSecteur.Count == 0)
            {
                ShowResRegion();
            }
        }


        private void ShowWorkRegion() // Afficher la région où il travaille
        {
            lblInfo.Text = "Vous travaillez dans la/les régions suivantes :";
            dgvResRegion.Visible = false;
            dgvResSecteur.Visible = false;
            linklblResRegion.Visible = false;
            linklblResSecteur.Visible = false;
            linklblTravail.Visible = false;
            linklblResRegion.Left = 47;
            linklblResSecteur.Left = 47;
            linklblTravail.Left = 47;

            dgvResponsabilite.Visible = true;

            for (int i = 0; i < dgvResponsabilite.ColumnCount; i++)
            {
                dgvResponsabilite.Columns[i].Visible = false;
            }

            // Resize dgvResponsabilité
            dgvResponsabilite.Top = 68;
            dgvResponsabilite.Left = 50;
            dgvResponsabilite.Size = new Size(380, 150);

            // Afficher les deux colonnes utiles
            dgvResponsabilite.Columns["idRegion"].Visible = true;
            dgvResponsabilite.Columns["idRegion"].HeaderText = "Num Région";
            dgvResponsabilite.Columns["idRegion"].DisplayIndex = 0;

            dgvResponsabilite.Columns["libRegion"].Visible = true;
            dgvResponsabilite.Columns["libRegion"].HeaderText = "Région";
            dgvResponsabilite.Columns["libRegion"].DisplayIndex = 1;

            // Si chef de région et chef de secteur
            if (bsResRegion.Count > 0 && bsResSecteur.Count > 0)
            {
                linklblResRegion.Top = 221;
                linklblResRegion.Text = "Cliquez ici pour voir les régions dont vous êtes responsable.";
                linklblResRegion.Visible = true;

                linklblResSecteur.Top = 242;
                linklblResSecteur.Text = "Cliquez ici pour voir les secteurs dont vous êtes responsable.";
                linklblResSecteur.Visible = true;
            }

            // Sinon si pas chef de région et est chef de secteur
            else if (bsResRegion.Count == 0 && bsResSecteur.Count > 0)
            {
                linklblResSecteur.Top = 221;
                linklblResSecteur.Text = "Cliquez ici pour voir les secteurs dont vous êtes responsable.";
                linklblResSecteur.Visible = true;
            }

            // Sinon si chef de région et pas chef de secteur
            else if (bsResRegion.Count > 0 && bsResSecteur.Count == 0)
            {
                linklblResRegion.Top = 221;
                linklblResRegion.Text = "Cliquez ici pour voir les régions dont vous êtes responsable.";
                linklblResRegion.Visible = true;
            }
        }


        private void ShowResRegion() // Afficher la région dont le visiteur est responsable
        {
            lblInfo.Text = "Vous êtes responsable de la/les régions suivantes :";
            dgvResponsabilite.Visible = false;
            dgvResSecteur.Visible = false;
            linklblResRegion.Visible = false;
            linklblResSecteur.Visible = false;
            linklblTravail.Visible = false;
            linklblResRegion.Left = 47;
            linklblResSecteur.Left = 47;
            linklblTravail.Left = 47;

            dgvResRegion.Visible = true;

            linklblResRegion.Visible = false;

            // Resize dgvResRegion
            dgvResRegion.Top = 68;
            dgvResRegion.Left = 50;
            dgvResRegion.Size = new Size(380, 150);

            for (int i = 0; i < dgvResRegion.ColumnCount; i++)
            {
                dgvResRegion.Columns[i].Visible = false;
            }

            dgvResRegion.Columns["idRegion"].Visible = true;
            dgvResRegion.Columns["idRegion"].HeaderText = "Num Région";
            dgvResRegion.Columns["idRegion"].DisplayIndex = 0;

            dgvResRegion.Columns["libRegion"].Visible = true;
            dgvResRegion.Columns["libRegion"].HeaderText = "Région";
            dgvResRegion.Columns["libRegion"].DisplayIndex = 1;

            // Si travaille et est chef de secteur
            if (bsTravailRegion.Count > 0 && bsResSecteur.Count > 0) 
            {
                linklblTravail.Top = 221;
                linklblTravail.Text = "Cliquez ici pour voir les régions où vous travaillez.";
                linklblTravail.Visible = true;

                linklblResSecteur.Top = 242;
                linklblResSecteur.Text = "Cliquez ici pour voir les secteurs dont vous êtes responsable.";
                linklblResSecteur.Visible = true;
            }

            // Sinon si ne travaille pas et est chef de secteur
            else if (bsTravailRegion.Count == 0 && bsResSecteur.Count > 0) 
            {
                linklblResSecteur.Top = 221;
                linklblResSecteur.Text = "Cliquez ici pour voir les secteurs dont vous êtes responsable.";
                linklblResSecteur.Visible = true;
            }

            // Sinon si travaille et n'est pas chef de secteur
            else if (bsTravailRegion.Count > 0 && bsResSecteur.Count == 0) 
            {
                linklblTravail.Top = 221;
                linklblTravail.Text = "Cliquez ici pour voir les régions où vous travaillez.";
                linklblTravail.Visible = true;
            }
        }

        private void ShowResSecteur() // Afficher le secteur dont le visiteur est responsable
        {
            lblInfo.Text = "Vous êtes responsable de ce/ces secteur(s) :";
            dgvResRegion.Visible = false;
            dgvResponsabilite.Visible = false;
            linklblResRegion.Visible = false;
            linklblResSecteur.Visible = false;
            linklblTravail.Visible = false;
            linklblResRegion.Left = 47;
            linklblResSecteur.Left = 47;
            linklblTravail.Left = 47;

            dgvResSecteur.Visible = true;

            // Resize dgvResRegion
            dgvResSecteur.Top = 68;
            dgvResSecteur.Left = 50;
            dgvResSecteur.Size = new Size(380, 150);

            for (int i = 0; i < dgvResSecteur.ColumnCount; i++)
            {
                dgvResSecteur.Columns[i].Visible = false;
            }

            dgvResSecteur.Columns["idSecteur"].Visible = true;
            dgvResSecteur.Columns["idSecteur"].HeaderText = "Num Secteur";
            dgvResSecteur.Columns["idSecteur"].DisplayIndex = 0;

            dgvResSecteur.Columns["libSecteur"].Visible = true;
            dgvResSecteur.Columns["libSecteur"].HeaderText = "Secteur";
            dgvResSecteur.Columns["libSecteur"].DisplayIndex = 1;

            // Si travaille et chef de région
            if (bsTravailRegion.Count > 0 && bsResRegion.Count > 0) 
            {
                linklblTravail.Top = 242;
                linklblTravail.Text = "Cliquez ici pour voir les régions où vous travaillez.";
                linklblTravail.Visible = true;

                linklblResRegion.Top = 221;
                linklblResRegion.Text = "Cliquez ici pour voir les régions dont vous êtes responsable.";
                linklblResRegion.Visible = true;
            }

            // Sinon si ne travaille pas et est chef de région
            else if (bsResRegion.Count > 0 && bsTravailRegion.Count == 0)  
            {
                linklblResRegion.Top = 221;
                linklblResRegion.Text = "Cliquez ici pour voir les régions dont vous êtes responsable.";
                linklblResRegion.Visible = true;
            }

            // Sinon si travaille et n'est pas chef de région
            else if (bsTravailRegion.Count > 0 && bsResRegion.Count == 0)
            {
                linklblTravail.Top = 221;
                linklblTravail.Text = "Cliquez ici pour voir les régions où vous travaillez.";
                linklblTravail.Visible = true;
            }
        }

        private void LinklblTravail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // Au clic, afficher régions où il travaille
        {
            ShowWorkRegion();
        }

        private void LinklblResRegion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // Au clic, afficher régions où il est responsable
        {
            ShowResRegion();
        }

        private void LinklblResSecteur_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowResSecteur();
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
