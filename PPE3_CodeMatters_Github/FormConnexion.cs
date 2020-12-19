using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PPE3_CodeMatters_Github
{
    public partial class FormConnexion : Form
    {
        // ToolTip au survol
        ToolTip tooltip1 = new ToolTip();


        public FormConnexion()
        {

            InitializeComponent();

        }


        private void enter_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string username = txtIdentifiant.Text;
            string password = txtpassword.Text;

            Modele.Connexion(username, password);
            if(Modele.validConnexion())
            {
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
                t.Start();
                this.Close();
            }

            else
            {
                MessageBox.Show("Identifiant ou mot de passe incorrect, réessayez");
                txtpassword.Clear();
                txtIdentifiant.Clear();
                txtpassword.Focus();
            }
        }

        public static void ThreadProc()
        {
            Application.Run(new FormMenu());
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormConnexion_Load(object sender, EventArgs e)
        {
            picHide.Visible = false;
            picShow.Visible = true;


        }

        private void TxtIdentifiant_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnConnexion_Click(this, new EventArgs());
            }
        }

        private void Txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnConnexion_Click(this, new EventArgs());
            }
        }

        private void picHide_Click(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = '*';
            picHide.Visible = false;
            picShow.Visible = true;
        }

        private void picShow_Click(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = '\0';
            picShow.Visible = false;
            picHide.Visible = true;
        }

        private void picShow_MouseHover(object sender, EventArgs e)
        {
            // Définir le délai 
            tooltip1.InitialDelay = 200;
            tooltip1.ReshowDelay = 200;
            tooltip1.ShowAlways = true;

            // Texte à afficher
            tooltip1.SetToolTip(this.picShow, "Montrer");
        }

        private void picHide_MouseHover(object sender, EventArgs e)
        {
            // Définir le délai 
            tooltip1.InitialDelay = 200;
            tooltip1.ReshowDelay = 200;
            tooltip1.ShowAlways = true;

            // Texte à afficher
            tooltip1.SetToolTip(this.picHide, "Cacher");
        }
    }
}
