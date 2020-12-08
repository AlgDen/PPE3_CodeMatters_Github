namespace PPE3_CodeMatters_Github
{
    partial class FModif
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
            this.tabModif = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.cboVehicule = new System.Windows.Forms.ComboBox();
            this.NbKm = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Total5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bsTypedeVehicule = new System.Windows.Forms.BindingSource(this.components);
            this.tabModif.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NbKm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTypedeVehicule)).BeginInit();
            this.SuspendLayout();
            // 
            // tabModif
            // 
            this.tabModif.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tabModif.ColumnCount = 3;
            this.tabModif.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.52284F));
            this.tabModif.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.47716F));
            this.tabModif.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tabModif.Controls.Add(this.label7, 0, 0);
            this.tabModif.Controls.Add(this.cboVehicule, 0, 1);
            this.tabModif.Controls.Add(this.NbKm, 1, 1);
            this.tabModif.Controls.Add(this.label5, 1, 0);
            this.tabModif.Controls.Add(this.label8, 2, 0);
            this.tabModif.Controls.Add(this.Total5, 2, 1);
            this.tabModif.Location = new System.Drawing.Point(7, 97);
            this.tabModif.Name = "tabModif";
            this.tabModif.RowCount = 2;
            this.tabModif.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabModif.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabModif.Size = new System.Drawing.Size(595, 71);
            this.tabModif.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label7.Location = new System.Drawing.Point(4, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Type de Véhicule";
            // 
            // cboVehicule
            // 
            this.cboVehicule.FormattingEnabled = true;
            this.cboVehicule.Location = new System.Drawing.Point(4, 39);
            this.cboVehicule.Name = "cboVehicule";
            this.cboVehicule.Size = new System.Drawing.Size(121, 21);
            this.cboVehicule.TabIndex = 22;
            this.cboVehicule.SelectedIndexChanged += new System.EventHandler(this.CboVehicule_SelectedIndexChanged);
            // 
            // NbKm
            // 
            this.NbKm.Location = new System.Drawing.Point(206, 39);
            this.NbKm.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.NbKm.Name = "NbKm";
            this.NbKm.Size = new System.Drawing.Size(120, 20);
            this.NbKm.TabIndex = 23;
            this.NbKm.ValueChanged += new System.EventHandler(this.NbKm_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(206, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 34);
            this.label5.TabIndex = 18;
            this.label5.Text = "Nombre de kilomètre\r\n parcourus";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label8.Location = new System.Drawing.Point(396, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "Total";
            // 
            // Total5
            // 
            this.Total5.AutoSize = true;
            this.Total5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total5.Location = new System.Drawing.Point(396, 36);
            this.Total5.Name = "Total5";
            this.Total5.Size = new System.Drawing.Size(37, 19);
            this.Total5.TabIndex = 24;
            this.Total5.Text = "0,00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(256, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 27);
            this.label4.TabIndex = 23;
            this.label4.Text = "Modification ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FModif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 231);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabModif);
            this.Name = "FModif";
            this.Text = "FModif";
            this.Load += new System.EventHandler(this.FModif_Load);
            this.tabModif.ResumeLayout(false);
            this.tabModif.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NbKm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTypedeVehicule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tabModif;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboVehicule;
        private System.Windows.Forms.NumericUpDown NbKm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Total5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bsTypedeVehicule;
    }
}