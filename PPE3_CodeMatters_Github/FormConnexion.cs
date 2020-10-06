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
    public partial class FormConnexion : Form
    {
        public FormConnexion()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if (txtIdentifiant.Text == "demo" && txtpassword.Text == "1234")
            {
                
               

            }

            else
            {
                MessageBox.Show("Identifiant ou mot de passe incorrect, réessayez");
                txtIdentifiant.Clear();
                txtpassword.Clear();
                txtIdentifiant.Focus();
            }
        }
    }
}
