namespace PPE3_CodeMatters_Github
{
    partial class FModifMDP
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
            this.txtNewMDP = new System.Windows.Forms.TextBox();
            this.txtVerifMDP = new System.Windows.Forms.TextBox();
            this.lblNomPage = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.bsVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.lblVerifNewMDP = new System.Windows.Forms.Label();
            this.lblNewMDP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNewMDP
            // 
            this.txtNewMDP.Location = new System.Drawing.Point(183, 73);
            this.txtNewMDP.Name = "txtNewMDP";
            this.txtNewMDP.Size = new System.Drawing.Size(100, 20);
            this.txtNewMDP.TabIndex = 2;
            // 
            // txtVerifMDP
            // 
            this.txtVerifMDP.Location = new System.Drawing.Point(183, 132);
            this.txtVerifMDP.Name = "txtVerifMDP";
            this.txtVerifMDP.Size = new System.Drawing.Size(100, 20);
            this.txtVerifMDP.TabIndex = 3;
            // 
            // lblNomPage
            // 
            this.lblNomPage.AutoSize = true;
            this.lblNomPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomPage.Location = new System.Drawing.Point(53, 20);
            this.lblNomPage.Name = "lblNomPage";
            this.lblNomPage.Size = new System.Drawing.Size(197, 24);
            this.lblNomPage.TabIndex = 4;
            this.lblNomPage.Text = "Modification Password";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(45, 184);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 5;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.BtnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(168, 184);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 6;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // lblVerifNewMDP
            // 
            this.lblVerifNewMDP.AutoSize = true;
            this.lblVerifNewMDP.Location = new System.Drawing.Point(12, 135);
            this.lblVerifNewMDP.Name = "lblVerifNewMDP";
            this.lblVerifNewMDP.Size = new System.Drawing.Size(165, 13);
            this.lblVerifNewMDP.TabIndex = 1;
            this.lblVerifNewMDP.Text = "Confirmation nouveau Password :";
            // 
            // lblNewMDP
            // 
            this.lblNewMDP.AutoSize = true;
            this.lblNewMDP.Location = new System.Drawing.Point(12, 76);
            this.lblNewMDP.Name = "lblNewMDP";
            this.lblNewMDP.Size = new System.Drawing.Size(106, 13);
            this.lblNewMDP.TabIndex = 0;
            this.lblNewMDP.Text = "Nouveau Password :";
            // 
            // FModifMDP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 230);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lblNomPage);
            this.Controls.Add(this.txtVerifMDP);
            this.Controls.Add(this.txtNewMDP);
            this.Controls.Add(this.lblVerifNewMDP);
            this.Controls.Add(this.lblNewMDP);
            this.Name = "FModifMDP";
            this.Text = "FModifMDP";
            this.Load += new System.EventHandler(this.FModifMDP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNewMDP;
        private System.Windows.Forms.TextBox txtVerifMDP;
        private System.Windows.Forms.Label lblNomPage;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.BindingSource bsVisiteur;
        private System.Windows.Forms.Label lblVerifNewMDP;
        private System.Windows.Forms.Label lblNewMDP;
    }
}