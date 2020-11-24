namespace PPE3_CodeMatters_Github
{
    partial class FormVisiteur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblInfos = new System.Windows.Forms.Label();
            this.bsVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtRue = new System.Windows.Forms.TextBox();
            this.txtEmbauche = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblRue = new System.Windows.Forms.Label();
            this.lblCP = new System.Windows.Forms.Label();
            this.lblEmbauche = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.btnValiderModif = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.lblNotif = new System.Windows.Forms.Label();
            this.btnModifMDP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfos
            // 
            this.lblInfos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfos.AutoSize = true;
            this.lblInfos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfos.Location = new System.Drawing.Point(12, 9);
            this.lblInfos.Name = "lblInfos";
            this.lblInfos.Size = new System.Drawing.Size(128, 20);
            this.lblInfos.TabIndex = 0;
            this.lblInfos.Text = "Vos informations";
            // 
            // bsVisiteur
            // 
            this.bsVisiteur.CurrentChanged += new System.EventHandler(this.BsVisiteur_CurrentChanged);
            // 
            // txtNom
            // 
            this.txtNom.Enabled = false;
            this.txtNom.Location = new System.Drawing.Point(115, 80);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 1;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Enabled = false;
            this.txtPrenom.Location = new System.Drawing.Point(115, 123);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtPrenom.TabIndex = 2;
            // 
            // txtRue
            // 
            this.txtRue.Enabled = false;
            this.txtRue.Location = new System.Drawing.Point(115, 172);
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(100, 20);
            this.txtRue.TabIndex = 3;
            // 
            // txtEmbauche
            // 
            this.txtEmbauche.Enabled = false;
            this.txtEmbauche.Location = new System.Drawing.Point(348, 172);
            this.txtEmbauche.Name = "txtEmbauche";
            this.txtEmbauche.Size = new System.Drawing.Size(100, 20);
            this.txtEmbauche.TabIndex = 4;
            // 
            // txtCP
            // 
            this.txtCP.Enabled = false;
            this.txtCP.Location = new System.Drawing.Point(348, 80);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(100, 20);
            this.txtCP.TabIndex = 5;
            // 
            // txtVille
            // 
            this.txtVille.Enabled = false;
            this.txtVille.Location = new System.Drawing.Point(348, 123);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(100, 20);
            this.txtVille.TabIndex = 6;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(52, 83);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 7;
            this.lblNom.Text = "Nom :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(52, 126);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(49, 13);
            this.lblPrenom.TabIndex = 8;
            this.lblPrenom.Text = "Prenom :";
            // 
            // lblRue
            // 
            this.lblRue.AutoSize = true;
            this.lblRue.Location = new System.Drawing.Point(54, 175);
            this.lblRue.Name = "lblRue";
            this.lblRue.Size = new System.Drawing.Size(33, 13);
            this.lblRue.TabIndex = 9;
            this.lblRue.Text = "Rue :";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(268, 83);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(70, 13);
            this.lblCP.TabIndex = 10;
            this.lblCP.Text = "Code Postal :";
            // 
            // lblEmbauche
            // 
            this.lblEmbauche.AutoSize = true;
            this.lblEmbauche.Location = new System.Drawing.Point(242, 175);
            this.lblEmbauche.Name = "lblEmbauche";
            this.lblEmbauche.Size = new System.Drawing.Size(100, 13);
            this.lblEmbauche.TabIndex = 11;
            this.lblEmbauche.Text = "Date d\'embauche : ";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(283, 126);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(32, 13);
            this.lblVille.TabIndex = 12;
            this.lblVille.Text = "Ville :";
            // 
            // btnValiderModif
            // 
            this.btnValiderModif.Location = new System.Drawing.Point(271, 235);
            this.btnValiderModif.Name = "btnValiderModif";
            this.btnValiderModif.Size = new System.Drawing.Size(75, 23);
            this.btnValiderModif.TabIndex = 14;
            this.btnValiderModif.Text = "Valider";
            this.btnValiderModif.UseVisualStyleBackColor = true;
            this.btnValiderModif.Visible = false;
            this.btnValiderModif.Click += new System.EventHandler(this.BtnValiderModif_Click);
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(159, 235);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(75, 23);
            this.btnModif.TabIndex = 15;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.BtnModif_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(159, 235);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 16;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Visible = false;
            this.btnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // lblNotif
            // 
            this.lblNotif.AutoSize = true;
            this.lblNotif.Location = new System.Drawing.Point(52, 235);
            this.lblNotif.Name = "lblNotif";
            this.lblNotif.Size = new System.Drawing.Size(35, 13);
            this.lblNotif.TabIndex = 17;
            this.lblNotif.Text = "label1";
            this.lblNotif.Visible = false;
            // 
            // btnModifMDP
            // 
            this.btnModifMDP.Location = new System.Drawing.Point(271, 235);
            this.btnModifMDP.Name = "btnModifMDP";
            this.btnModifMDP.Size = new System.Drawing.Size(107, 23);
            this.btnModifMDP.TabIndex = 18;
            this.btnModifMDP.Text = "Modifier Password";
            this.btnModifMDP.UseVisualStyleBackColor = true;
            this.btnModifMDP.Click += new System.EventHandler(this.BtnModifMDP_Click);
            // 
            // FormVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 280);
            this.Controls.Add(this.btnModifMDP);
            this.Controls.Add(this.lblNotif);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.btnValiderModif);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.lblEmbauche);
            this.Controls.Add(this.lblCP);
            this.Controls.Add(this.lblRue);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.txtEmbauche);
            this.Controls.Add(this.txtRue);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblInfos);
            this.Name = "FormVisiteur";
            this.Text = "FormVisiteur";
            this.Load += new System.EventHandler(this.FormVisiteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfos;
        private System.Windows.Forms.BindingSource bsVisiteur;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtRue;
        private System.Windows.Forms.TextBox txtEmbauche;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblRue;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.Label lblEmbauche;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Button btnValiderModif;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label lblNotif;
        private System.Windows.Forms.Button btnModifMDP;
    }
}