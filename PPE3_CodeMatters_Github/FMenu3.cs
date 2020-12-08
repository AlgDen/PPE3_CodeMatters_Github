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
    public partial class FMenu3 : Form
    {
        private bool erreur;
        public FMenu3()
        {
            InitializeComponent();
        }



        private void FMenu3_Load(object sender, EventArgs e)
        {
            cboVisiteur.ValueMember = "idVisiteur";
            cboVisiteur.DisplayMember = "idVisiteur";
            bsFrais.DataSource = Modele.listeVisiteur();
            cboVisiteur.DataSource = bsFrais;
            bsLigneFicheFrais.DataSource = Modele.listelignefraisforfait();
          
            bsFraisForfait.DataSource = Modele.listefraisforfait();

            bsFraisForfait.DataSource = Modele.recherchefraisforfait("NUI");
            LbMUNuite.Text = ((FraisForfait)bsFraisForfait[0]).montant.ToString();
            bsFraisForfait.DataSource = Modele.recherchefraisforfait("RPM");
            LbRM.Text = ((FraisForfait)bsFraisForfait[0]).montant.ToString();
            bsFraisForfait.DataSource = Modele.recherchefraisforfait("RPS");
            LbRS.Text = ((FraisForfait)bsFraisForfait[0]).montant.ToString();

            cboVehicule.ValueMember = "id";
            cboVehicule.DisplayMember = "libelle";
            bsTypedeVehicule.DataSource = Modele.recherchefraiskilometrique();
            cboVehicule.DataSource = bsTypedeVehicule;

            


        }

        private void BsFrais_CurrentChanged(object sender, EventArgs e)
        {
            labnom.Text = ((Visiteur)bsFrais.Current).nom;
            labprenom.Text = ((Visiteur)bsFrais.Current).prenom;

        }

       

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QtéNuité_ValueChanged(object sender, EventArgs e)
        {
            double a, b, c;
            a = (double)QtéNuité.Value;
            b = double.Parse(LbMUNuite.Text);
            c = a * b;
            Total1.Text = c.ToString();
        }

        private void QtéRM_ValueChanged(object sender, EventArgs e)
        {
            
            double a, b, c;
            a = (double)QtéRM.Value;
            b = double.Parse(LbRM.Text);
            c = a * b;
            Total2.Text = c.ToString();
        }

        private void QtéRS_ValueChanged(object sender, EventArgs e)
        {
            double a, b, c;
            a = (double)QtéRS.Value;
            b = double.Parse(LbRS.Text);
            c = a * b;
            Total3.Text = c.ToString();
        }

        private void NbKm_ValueChanged(object sender, EventArgs e)
        {

            String test = cboVehicule.Text;
            foreach (FraisForfait vehicule in bsTypedeVehicule)
            {
                if (vehicule.libelle == test)
                {
                    Total5.Text = (vehicule.montant*NbKm.Value).ToString();
                }
            }

        }

        private void CboVehicule_SelectedIndexChanged(object sender, EventArgs e)
        {
            Total5.Text = "0";
            NbKm.Value = 0;
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            if (dgvVehicule.RowCount>0)
            {
                string[] row = new string[] { cboVehicule.Text, NbKm.Value.ToString(), Total5.Text};
                dgvVehicule.Rows.Add(row);
            }
        }

       
        private void BtnSupprimer_Click_1(object sender, EventArgs e)
        {
            if (dgvVehicule.CurrentRow.Selected == true)
            {
                int rowIndex = dgvVehicule.CurrentCell.RowIndex;
                DialogResult res = MessageBox.Show("Vous voulez vraiment supprimer cette ligne ? ", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.OK)
                {
                    dgvVehicule.Rows.RemoveAt(rowIndex);
                }

            }
            else
            {
                MessageBox.Show("Selectionner la ligne que vous voulez supprimer","ATTENTION");
            }

        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            if (dgvVehicule.CurrentRow.Selected == true)
            {

                DialogResult res = MessageBox.Show("Vous voulez vraiment modifer cette ligne ? ", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.OK)
                {
                    FModif FM = new FModif((string)dgvVehicule.CurrentRow.Cells[0].Value, int.Parse((string)dgvVehicule.CurrentRow.Cells[1].Value), decimal.Parse((string)dgvVehicule.CurrentRow.Cells[2].Value));
                   // FModif FM = new FModif((string)dgvVehicule.CurrentRow.Cells[0].Value,1,2);
                    FM.Show();
                }
            }

            else
            {
                MessageBox.Show("Selectionner la ligne que vous voulez modifer","ATTENTION");
            }


        }
    }
}
