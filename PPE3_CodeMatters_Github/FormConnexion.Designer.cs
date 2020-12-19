namespace PPE3_CodeMatters_Github
{
    partial class FormConnexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.picHide = new System.Windows.Forms.PictureBox();
            this.picShow = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Location = new System.Drawing.Point(103, 108);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(162, 20);
            this.txtIdentifiant.TabIndex = 7;
            this.txtIdentifiant.Text = "deni";
            this.txtIdentifiant.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtIdentifiant_KeyDown);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(103, 151);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(162, 20);
            this.txtpassword.TabIndex = 8;
            this.txtpassword.Text = "denilebo1";
            this.txtpassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtpassword_KeyDown);
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(103, 191);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(75, 23);
            this.btnConnexion.TabIndex = 9;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.FlatAppearance.BorderSize = 0;
            this.btnQuitter.Location = new System.Drawing.Point(190, 191);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 10;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.BackColor = System.Drawing.Color.Transparent;
            this.lblIdentifiant.Location = new System.Drawing.Point(151, 92);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(62, 13);
            this.lblIdentifiant.TabIndex = 11;
            this.lblIdentifiant.Text = "Identifiant : ";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Location = new System.Drawing.Point(151, 135);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(62, 13);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "Password : ";
            // 
            // picHide
            // 
            this.picHide.BackColor = System.Drawing.Color.Transparent;
            this.picHide.Image = global::PPE3_CodeMatters_Github.Properties.Resources.hide;
            this.picHide.Location = new System.Drawing.Point(239, 153);
            this.picHide.Name = "picHide";
            this.picHide.Size = new System.Drawing.Size(24, 16);
            this.picHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picHide.TabIndex = 15;
            this.picHide.TabStop = false;
            this.picHide.Click += new System.EventHandler(this.picHide_Click);
            this.picHide.MouseHover += new System.EventHandler(this.picHide_MouseHover);
            // 
            // picShow
            // 
            this.picShow.BackColor = System.Drawing.Color.Transparent;
            this.picShow.Image = global::PPE3_CodeMatters_Github.Properties.Resources.show;
            this.picShow.Location = new System.Drawing.Point(240, 153);
            this.picShow.Name = "picShow";
            this.picShow.Size = new System.Drawing.Size(23, 16);
            this.picShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picShow.TabIndex = 14;
            this.picShow.TabStop = false;
            this.picShow.Click += new System.EventHandler(this.picShow_Click);
            this.picShow.MouseHover += new System.EventHandler(this.picShow_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PPE3_CodeMatters_Github.Properties.Resources.gsb;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(365, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // FormConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(365, 232);
            this.Controls.Add(this.picHide);
            this.Controls.Add(this.picShow);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblIdentifiant);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtIdentifiant);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulaire Connexion";
            this.Load += new System.EventHandler(this.FormConnexion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picShow;
        private System.Windows.Forms.PictureBox picHide;
    }
}

