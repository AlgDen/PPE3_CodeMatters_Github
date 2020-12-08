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
    public partial class FModif : Form

    {
        private string typedevehicule;
        private int nbKm;
        private decimal total;

        public FModif(string typedevehicule, int nbKm, decimal total)
        {
            this.typedevehicule = typedevehicule;
            this.nbKm = nbKm;
            this.total = total;

            InitializeComponent();
           
        }

        private void CboVehicule_SelectedIndexChanged(object sender, EventArgs e)
        {
            Total5.Text = "0";
            NbKm.Value = 0;
        }

        private void NbKm_ValueChanged(object sender, EventArgs e)
        {
            
            String test = cboVehicule.Text;
            foreach (FraisForfait vehicule in bsTypedeVehicule)
            {
                if (vehicule.libelle == test)
                {
                    Total5.Text = (vehicule.montant * NbKm.Value).ToString();
                }
            }
        }

        private void FModif_Load(object sender, EventArgs e)
        {
            cboVehicule.ValueMember = "id";
            cboVehicule.DisplayMember = "libelle";
            bsTypedeVehicule.DataSource = Modele.recherchefraiskilometrique();
            cboVehicule.DataSource = bsTypedeVehicule;
            cboVehicule.Text = this.typedevehicule;
            

        }

        
    }
}
