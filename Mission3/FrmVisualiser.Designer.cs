namespace Mission3
{
    partial class FrmVisualiser
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
            this.btnGenererXml = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.grbxVisiteurs = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxVisiteursPrenom = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxVisiteursNom = new System.Windows.Forms.ComboBox();
            this.grbxVisiteurs.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenererXml
            // 
            this.btnGenererXml.Location = new System.Drawing.Point(336, 168);
            this.btnGenererXml.Name = "btnGenererXml";
            this.btnGenererXml.Size = new System.Drawing.Size(75, 23);
            this.btnGenererXml.TabIndex = 49;
            this.btnGenererXml.Text = "Générer";
            this.btnGenererXml.UseVisualStyleBackColor = true;
            this.btnGenererXml.Click += new System.EventHandler(this.btnGenererXml_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(505, 98);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Date";
            // 
            // grbxVisiteurs
            // 
            this.grbxVisiteurs.Controls.Add(this.label10);
            this.grbxVisiteurs.Controls.Add(this.cbxVisiteursPrenom);
            this.grbxVisiteurs.Controls.Add(this.label6);
            this.grbxVisiteurs.Controls.Add(this.cbxVisiteursNom);
            this.grbxVisiteurs.Location = new System.Drawing.Point(84, 41);
            this.grbxVisiteurs.Name = "grbxVisiteurs";
            this.grbxVisiteurs.Size = new System.Drawing.Size(283, 102);
            this.grbxVisiteurs.TabIndex = 50;
            this.grbxVisiteurs.TabStop = false;
            this.grbxVisiteurs.Text = "Visiteurs";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Prenom*";
            // 
            // cbxVisiteursPrenom
            // 
            this.cbxVisiteursPrenom.FormattingEnabled = true;
            this.cbxVisiteursPrenom.Location = new System.Drawing.Point(80, 62);
            this.cbxVisiteursPrenom.Name = "cbxVisiteursPrenom";
            this.cbxVisiteursPrenom.Size = new System.Drawing.Size(133, 21);
            this.cbxVisiteursPrenom.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nom*";
            // 
            // cbxVisiteursNom
            // 
            this.cbxVisiteursNom.FormattingEnabled = true;
            this.cbxVisiteursNom.Location = new System.Drawing.Point(80, 26);
            this.cbxVisiteursNom.Name = "cbxVisiteursNom";
            this.cbxVisiteursNom.Size = new System.Drawing.Size(133, 21);
            this.cbxVisiteursNom.TabIndex = 10;
            this.cbxVisiteursNom.SelectedIndexChanged += new System.EventHandler(this.cbxVisiteursNom_SelectedIndexChanged);
            // 
            // FrmVisualiser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbxVisiteurs);
            this.Controls.Add(this.btnGenererXml);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Name = "FrmVisualiser";
            this.Text = "FrmVisualiser";
            this.Load += new System.EventHandler(this.FrmVisualiser_Load);
            this.grbxVisiteurs.ResumeLayout(false);
            this.grbxVisiteurs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGenererXml;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbxVisiteurs;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxVisiteursPrenom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxVisiteursNom;
    }
}