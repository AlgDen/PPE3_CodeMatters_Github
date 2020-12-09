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
            this.dgvResponsabilite = new System.Windows.Forms.DataGridView();
            this.lblInfo = new System.Windows.Forms.Label();
            this.linklblTravail = new System.Windows.Forms.LinkLabel();
            this.bsResRegion = new System.Windows.Forms.BindingSource(this.components);
            this.bsTravailRegion = new System.Windows.Forms.BindingSource(this.components);
            this.dgvResRegion = new System.Windows.Forms.DataGridView();
            this.linklblResRegion = new System.Windows.Forms.LinkLabel();
            this.bsResSecteur = new System.Windows.Forms.BindingSource(this.components);
            this.linklblResSecteur = new System.Windows.Forms.LinkLabel();
            this.dgvResSecteur = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponsabilite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResRegion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTravailRegion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResRegion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResSecteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResSecteur)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfos
            // 
            this.lblInfos.AutoSize = true;
            this.lblInfos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfos.Location = new System.Drawing.Point(159, 20);
            this.lblInfos.Name = "lblInfos";
            this.lblInfos.Size = new System.Drawing.Size(149, 24);
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
            this.txtNom.Location = new System.Drawing.Point(97, 268);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 1;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Enabled = false;
            this.txtPrenom.Location = new System.Drawing.Point(97, 311);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtPrenom.TabIndex = 2;
            // 
            // txtRue
            // 
            this.txtRue.Enabled = false;
            this.txtRue.Location = new System.Drawing.Point(97, 355);
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(100, 20);
            this.txtRue.TabIndex = 3;
            // 
            // txtEmbauche
            // 
            this.txtEmbauche.Enabled = false;
            this.txtEmbauche.Location = new System.Drawing.Point(330, 355);
            this.txtEmbauche.Name = "txtEmbauche";
            this.txtEmbauche.Size = new System.Drawing.Size(100, 20);
            this.txtEmbauche.TabIndex = 4;
            // 
            // txtCP
            // 
            this.txtCP.Enabled = false;
            this.txtCP.Location = new System.Drawing.Point(330, 268);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(100, 20);
            this.txtCP.TabIndex = 5;
            // 
            // txtVille
            // 
            this.txtVille.Enabled = false;
            this.txtVille.Location = new System.Drawing.Point(330, 311);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(100, 20);
            this.txtVille.TabIndex = 6;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(34, 271);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 7;
            this.lblNom.Text = "Nom :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(34, 314);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(49, 13);
            this.lblPrenom.TabIndex = 8;
            this.lblPrenom.Text = "Prenom :";
            // 
            // lblRue
            // 
            this.lblRue.AutoSize = true;
            this.lblRue.Location = new System.Drawing.Point(36, 358);
            this.lblRue.Name = "lblRue";
            this.lblRue.Size = new System.Drawing.Size(33, 13);
            this.lblRue.TabIndex = 9;
            this.lblRue.Text = "Rue :";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(250, 271);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(70, 13);
            this.lblCP.TabIndex = 10;
            this.lblCP.Text = "Code Postal :";
            // 
            // lblEmbauche
            // 
            this.lblEmbauche.AutoSize = true;
            this.lblEmbauche.Location = new System.Drawing.Point(224, 358);
            this.lblEmbauche.Name = "lblEmbauche";
            this.lblEmbauche.Size = new System.Drawing.Size(100, 13);
            this.lblEmbauche.TabIndex = 11;
            this.lblEmbauche.Text = "Date d\'embauche : ";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(265, 314);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(32, 13);
            this.lblVille.TabIndex = 12;
            this.lblVille.Text = "Ville :";
            // 
            // btnValiderModif
            // 
            this.btnValiderModif.Location = new System.Drawing.Point(253, 411);
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
            this.btnModif.Location = new System.Drawing.Point(141, 411);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(75, 23);
            this.btnModif.TabIndex = 15;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.BtnModif_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(141, 411);
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
            this.lblNotif.Location = new System.Drawing.Point(34, 411);
            this.lblNotif.Name = "lblNotif";
            this.lblNotif.Size = new System.Drawing.Size(35, 13);
            this.lblNotif.TabIndex = 17;
            this.lblNotif.Text = "label1";
            this.lblNotif.Visible = false;
            // 
            // btnModifMDP
            // 
            this.btnModifMDP.Location = new System.Drawing.Point(253, 411);
            this.btnModifMDP.Name = "btnModifMDP";
            this.btnModifMDP.Size = new System.Drawing.Size(107, 23);
            this.btnModifMDP.TabIndex = 18;
            this.btnModifMDP.Text = "Modifier Password";
            this.btnModifMDP.UseVisualStyleBackColor = true;
            this.btnModifMDP.Click += new System.EventHandler(this.BtnModifMDP_Click);
            // 
            // dgvResponsabilite
            // 
            this.dgvResponsabilite.AllowUserToAddRows = false;
            this.dgvResponsabilite.AllowUserToDeleteRows = false;
            this.dgvResponsabilite.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvResponsabilite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResponsabilite.Location = new System.Drawing.Point(50, 68);
            this.dgvResponsabilite.Name = "dgvResponsabilite";
            this.dgvResponsabilite.ReadOnly = true;
            this.dgvResponsabilite.Size = new System.Drawing.Size(80, 22);
            this.dgvResponsabilite.TabIndex = 19;
            this.dgvResponsabilite.Visible = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(48, 52);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(71, 13);
            this.lblInfo.TabIndex = 20;
            this.lblInfo.Text = "Anonymous ?";
            // 
            // linklblTravail
            // 
            this.linklblTravail.AutoSize = true;
            this.linklblTravail.Location = new System.Drawing.Point(47, 221);
            this.linklblTravail.Name = "linklblTravail";
            this.linklblTravail.Size = new System.Drawing.Size(55, 13);
            this.linklblTravail.TabIndex = 21;
            this.linklblTravail.TabStop = true;
            this.linklblTravail.Text = "linkLabel1";
            this.linklblTravail.Visible = false;
            this.linklblTravail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinklblTravail_LinkClicked);
            // 
            // dgvResRegion
            // 
            this.dgvResRegion.AllowUserToAddRows = false;
            this.dgvResRegion.AllowUserToDeleteRows = false;
            this.dgvResRegion.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvResRegion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResRegion.Location = new System.Drawing.Point(141, 68);
            this.dgvResRegion.Name = "dgvResRegion";
            this.dgvResRegion.ReadOnly = true;
            this.dgvResRegion.Size = new System.Drawing.Size(80, 22);
            this.dgvResRegion.TabIndex = 22;
            this.dgvResRegion.Visible = false;
            // 
            // linklblResRegion
            // 
            this.linklblResRegion.AutoSize = true;
            this.linklblResRegion.Location = new System.Drawing.Point(108, 221);
            this.linklblResRegion.Name = "linklblResRegion";
            this.linklblResRegion.Size = new System.Drawing.Size(55, 13);
            this.linklblResRegion.TabIndex = 23;
            this.linklblResRegion.TabStop = true;
            this.linklblResRegion.Text = "linkLabel1";
            this.linklblResRegion.Visible = false;
            this.linklblResRegion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinklblResRegion_LinkClicked);
            // 
            // linklblResSecteur
            // 
            this.linklblResSecteur.AutoSize = true;
            this.linklblResSecteur.Location = new System.Drawing.Point(47, 242);
            this.linklblResSecteur.Name = "linklblResSecteur";
            this.linklblResSecteur.Size = new System.Drawing.Size(55, 13);
            this.linklblResSecteur.TabIndex = 24;
            this.linklblResSecteur.TabStop = true;
            this.linklblResSecteur.Text = "linkLabel1";
            this.linklblResSecteur.Visible = false;
            this.linklblResSecteur.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinklblResSecteur_LinkClicked);
            // 
            // dgvResSecteur
            // 
            this.dgvResSecteur.AllowUserToAddRows = false;
            this.dgvResSecteur.AllowUserToDeleteRows = false;
            this.dgvResSecteur.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvResSecteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResSecteur.Location = new System.Drawing.Point(231, 68);
            this.dgvResSecteur.Name = "dgvResSecteur";
            this.dgvResSecteur.ReadOnly = true;
            this.dgvResSecteur.Size = new System.Drawing.Size(80, 22);
            this.dgvResSecteur.TabIndex = 25;
            this.dgvResSecteur.Visible = false;
            // 
            // FormVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 462);
            this.Controls.Add(this.dgvResSecteur);
            this.Controls.Add(this.linklblResSecteur);
            this.Controls.Add(this.linklblResRegion);
            this.Controls.Add(this.dgvResRegion);
            this.Controls.Add(this.linklblTravail);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.dgvResponsabilite);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponsabilite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResRegion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTravailRegion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResRegion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResSecteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResSecteur)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvResponsabilite;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.LinkLabel linklblTravail;
        private System.Windows.Forms.BindingSource bsResRegion;
        private System.Windows.Forms.BindingSource bsTravailRegion;
        private System.Windows.Forms.DataGridView dgvResRegion;
        private System.Windows.Forms.LinkLabel linklblResRegion;
        private System.Windows.Forms.BindingSource bsResSecteur;
        private System.Windows.Forms.LinkLabel linklblResSecteur;
        private System.Windows.Forms.DataGridView dgvResSecteur;
    }
}