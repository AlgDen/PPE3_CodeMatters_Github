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
    public partial class FModifMDP : Form
    {
        public FModifMDP()
        {
            InitializeComponent();
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            if(txtNewMDP.Text == txtVerifMDP.Text)
            {
                if (Modele.ModifMDP(txtNewMDP.Text))
                {
                    MessageBox.Show("Le mot de passe a été modifié.", "Succès", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("La modification a échoué.", "Erreur", MessageBoxButtons.OK);

                }
            }
            else
            {
                MessageBox.Show("Les champs nouveau mot de passe ne correspondent pas.", "Erreur", MessageBoxButtons.OK);
            }
        }

        private void FModifMDP_Load(object sender, EventArgs e)
        {
            bsVisiteur.DataSource = Modele.ViConnecte();
        }
    }
}
