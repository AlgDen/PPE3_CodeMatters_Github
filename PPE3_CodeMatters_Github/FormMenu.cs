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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent(); //fg
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
            FormVisiteur open = new FormVisiteur();
            open.FormBorderStyle = FormBorderStyle.None;
            open.TopLevel = false;
            panel1.Controls.Add(open);
            open.Show();
        }
    }
}
