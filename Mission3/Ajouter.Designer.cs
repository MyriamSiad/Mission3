namespace Mission3
{
    partial class lblAdresse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lblAdresse));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxMedecinNom = new System.Windows.Forms.ComboBox();
            this.cbxVisiteursNom = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxMedecinPrenom = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbMedecin = new System.Windows.Forms.GroupBox();
            this.prenom = new System.Windows.Forms.Label();
            this.grbxVisiteurs = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxVisiteursPrenom = new System.Windows.Forms.ComboBox();
            this.lblId = new System.Windows.Forms.Label();
            this.cmbId = new System.Windows.Forms.ComboBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.cbxMotif = new System.Windows.Forms.ComboBox();
            this.cbxBilan = new System.Windows.Forms.ComboBox();
            this.dtgMedicament = new System.Windows.Forms.DataGridView();
            this.lblNbrMedicamament = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbMedecin.SuspendLayout();
            this.grbxVisiteurs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicament)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(392, 167);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Motif*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Bilan*";
            // 
            // cbxMedecinNom
            // 
            this.cbxMedecinNom.FormattingEnabled = true;
            this.cbxMedecinNom.Location = new System.Drawing.Point(90, 33);
            this.cbxMedecinNom.Name = "cbxMedecinNom";
            this.cbxMedecinNom.Size = new System.Drawing.Size(150, 21);
            this.cbxMedecinNom.TabIndex = 9;
            this.cbxMedecinNom.SelectedIndexChanged += new System.EventHandler(this.cbxMedecin_SelectedIndexChanged);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nom*";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(306, 452);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrer.TabIndex = 14;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(400, 372);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(233, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Les éléments marque par un (*) sont obligatoire !";
            // 
            // cbxMedecinPrenom
            // 
            this.cbxMedecinPrenom.FormattingEnabled = true;
            this.cbxMedecinPrenom.Location = new System.Drawing.Point(119, 73);
            this.cbxMedecinPrenom.Name = "cbxMedecinPrenom";
            this.cbxMedecinPrenom.Size = new System.Drawing.Size(121, 21);
            this.cbxMedecinPrenom.TabIndex = 16;
            this.cbxMedecinPrenom.SelectedIndexChanged += new System.EventHandler(this.cbxMedecinPrenom_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Nom*";
            // 
            // grbMedecin
            // 
            this.grbMedecin.Controls.Add(this.prenom);
            this.grbMedecin.Controls.Add(this.cbxMedecinNom);
            this.grbMedecin.Controls.Add(this.label9);
            this.grbMedecin.Controls.Add(this.cbxMedecinPrenom);
            this.grbMedecin.Location = new System.Drawing.Point(8, 248);
            this.grbMedecin.Name = "grbMedecin";
            this.grbMedecin.Size = new System.Drawing.Size(256, 100);
            this.grbMedecin.TabIndex = 18;
            this.grbMedecin.TabStop = false;
            this.grbMedecin.Text = "Medecins";
            // 
            // prenom
            // 
            this.prenom.AutoSize = true;
            this.prenom.Location = new System.Drawing.Point(11, 76);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(47, 13);
            this.prenom.TabIndex = 18;
            this.prenom.Text = "Prenom*";
            // 
            // grbxVisiteurs
            // 
            this.grbxVisiteurs.Controls.Add(this.label10);
            this.grbxVisiteurs.Controls.Add(this.cbxVisiteursPrenom);
            this.grbxVisiteurs.Controls.Add(this.label6);
            this.grbxVisiteurs.Controls.Add(this.cbxVisiteursNom);
            this.grbxVisiteurs.Location = new System.Drawing.Point(350, 248);
            this.grbxVisiteurs.Name = "grbxVisiteurs";
            this.grbxVisiteurs.Size = new System.Drawing.Size(283, 102);
            this.grbxVisiteurs.TabIndex = 19;
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
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(37, 377);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(29, 13);
            this.lblId.TabIndex = 21;
            this.lblId.Text = "Id : *";
            this.lblId.Visible = false;
            // 
            // cmbId
            // 
            this.cmbId.FormattingEnabled = true;
            this.cmbId.Location = new System.Drawing.Point(76, 369);
            this.cmbId.Name = "cmbId";
            this.cmbId.Size = new System.Drawing.Size(121, 21);
            this.cmbId.TabIndex = 22;
            this.cmbId.Visible = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(41, 406);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(297, 13);
            this.lblMessage.TabIndex = 23;
            this.lblMessage.Text = "Vous devez impérativement choisir un ID ! (Il y a un doublons)";
            this.lblMessage.Visible = false;
            this.lblMessage.Click += new System.EventHandler(this.label7_Click_1);
            // 
            // cbxMotif
            // 
            this.cbxMotif.FormattingEnabled = true;
            this.cbxMotif.Location = new System.Drawing.Point(56, 221);
            this.cbxMotif.Name = "cbxMotif";
            this.cbxMotif.Size = new System.Drawing.Size(150, 21);
            this.cbxMotif.TabIndex = 24;
            // 
            // cbxBilan
            // 
            this.cbxBilan.FormattingEnabled = true;
            this.cbxBilan.Location = new System.Drawing.Point(433, 213);
            this.cbxBilan.Name = "cbxBilan";
            this.cbxBilan.Size = new System.Drawing.Size(150, 21);
            this.cbxBilan.TabIndex = 25;
            // 
            // dtgMedicament
            // 
            this.dtgMedicament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMedicament.Location = new System.Drawing.Point(44, 30);
            this.dtgMedicament.Name = "dtgMedicament";
            this.dtgMedicament.Size = new System.Drawing.Size(260, 150);
            this.dtgMedicament.TabIndex = 32;
            // 
            // lblNbrMedicamament
            // 
            this.lblNbrMedicamament.AutoSize = true;
            this.lblNbrMedicamament.Location = new System.Drawing.Point(41, 9);
            this.lblNbrMedicamament.Name = "lblNbrMedicamament";
            this.lblNbrMedicamament.Size = new System.Drawing.Size(192, 13);
            this.lblNbrMedicamament.TabIndex = 29;
            this.lblNbrMedicamament.Text = "Nombre de medicament offert différents";
            this.lblNbrMedicamament.Click += new System.EventHandler(this.lblNbrMedicamament_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(452, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 131);
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // lblAdresse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 490);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtgMedicament);
            this.Controls.Add(this.lblNbrMedicamament);
            this.Controls.Add(this.cbxBilan);
            this.Controls.Add(this.cbxMotif);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.cmbId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.grbxVisiteurs);
            this.Controls.Add(this.grbMedecin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "lblAdresse";
            this.Text = "Ajouter";
            this.Load += new System.EventHandler(this.Ajouter_Load);
            this.grbMedecin.ResumeLayout(false);
            this.grbMedecin.PerformLayout();
            this.grbxVisiteurs.ResumeLayout(false);
            this.grbxVisiteurs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicament)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxMedecinNom;
        private System.Windows.Forms.ComboBox cbxVisiteursNom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxMedecinPrenom;
        private System.Windows.Forms.Label label9;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grbMedecin;
        private System.Windows.Forms.Label prenom;
        private System.Windows.Forms.GroupBox grbxVisiteurs;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxVisiteursPrenom;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox cmbId;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ComboBox cbxMotif;
        private System.Windows.Forms.ComboBox cbxBilan;
        private System.Windows.Forms.DataGridView dtgMedicament;
        private System.Windows.Forms.Label lblNbrMedicamament;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}