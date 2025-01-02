namespace Mission3
{
    partial class FrmModifier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModifier));
            this.datepicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.grbxVisiteurs = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxVisiteursPrenom = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxVisiteursNom = new System.Windows.Forms.ComboBox();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.BdgNavRapport = new System.Windows.Forms.BindingNavigator(this.components);
            this.lbldate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxMotif = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxBilan = new System.Windows.Forms.ComboBox();
            this.grpBoxDate = new System.Windows.Forms.GroupBox();
            this.dtgMedicament = new System.Windows.Forms.DataGridView();
            this.BdgSourceOffrir = new System.Windows.Forms.BindingSource(this.components);
            this.grbxVisiteurs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BdgNavRapport)).BeginInit();
            this.BdgNavRapport.SuspendLayout();
            this.grpBoxDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicament)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BdgSourceOffrir)).BeginInit();
            this.SuspendLayout();
            // 
            // datepicker
            // 
            this.datepicker.Location = new System.Drawing.Point(121, 39);
            this.datepicker.Name = "datepicker";
            this.datepicker.Size = new System.Drawing.Size(200, 20);
            this.datepicker.TabIndex = 14;
            this.datepicker.ValueChanged += new System.EventHandler(this.datepicker_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Date";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(326, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Ok ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // grbxVisiteurs
            // 
            this.grbxVisiteurs.Controls.Add(this.label10);
            this.grbxVisiteurs.Controls.Add(this.cbxVisiteursPrenom);
            this.grbxVisiteurs.Controls.Add(this.label6);
            this.grbxVisiteurs.Controls.Add(this.cbxVisiteursNom);
            this.grbxVisiteurs.Location = new System.Drawing.Point(473, 28);
            this.grbxVisiteurs.Name = "grbxVisiteurs";
            this.grbxVisiteurs.Size = new System.Drawing.Size(283, 102);
            this.grbxVisiteurs.TabIndex = 23;
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
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // BdgNavRapport
            // 
            this.BdgNavRapport.AddNewItem = this.bindingNavigatorAddNewItem;
            this.BdgNavRapport.CountItem = this.bindingNavigatorCountItem;
            this.BdgNavRapport.DeleteItem = this.bindingNavigatorDeleteItem;
            this.BdgNavRapport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.BdgNavRapport.Location = new System.Drawing.Point(0, 0);
            this.BdgNavRapport.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.BdgNavRapport.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.BdgNavRapport.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.BdgNavRapport.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.BdgNavRapport.Name = "BdgNavRapport";
            this.BdgNavRapport.PositionItem = this.bindingNavigatorPositionItem;
            this.BdgNavRapport.Size = new System.Drawing.Size(800, 25);
            this.BdgNavRapport.TabIndex = 31;
            this.BdgNavRapport.Text = "bindingNavigator1";
            this.BdgNavRapport.RefreshItems += new System.EventHandler(this.BdgNavRapport_RefreshItems);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(17, 38);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(30, 13);
            this.lbldate.TabIndex = 33;
            this.lbldate.Text = "Date";
            this.lbldate.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Numero";
            this.label1.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(154, 110);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 36;
            this.txtId.Visible = false;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(364, 300);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrer.TabIndex = 38;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Visible = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(342, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Motif*";
            this.label7.Visible = false;
            // 
            // cbxMotif
            // 
            this.cbxMotif.FormattingEnabled = true;
            this.cbxMotif.Location = new System.Drawing.Point(382, 236);
            this.cbxMotif.Name = "cbxMotif";
            this.cbxMotif.Size = new System.Drawing.Size(150, 21);
            this.cbxMotif.TabIndex = 40;
            this.cbxMotif.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Bilan*";
            this.label4.Visible = false;
            // 
            // cbxBilan
            // 
            this.cbxBilan.FormattingEnabled = true;
            this.cbxBilan.Location = new System.Drawing.Point(382, 182);
            this.cbxBilan.Name = "cbxBilan";
            this.cbxBilan.Size = new System.Drawing.Size(150, 21);
            this.cbxBilan.TabIndex = 42;
            this.cbxBilan.Visible = false;
            // 
            // grpBoxDate
            // 
            this.grpBoxDate.Controls.Add(this.lbldate);
            this.grpBoxDate.Location = new System.Drawing.Point(553, 147);
            this.grpBoxDate.Name = "grpBoxDate";
            this.grpBoxDate.Size = new System.Drawing.Size(189, 96);
            this.grpBoxDate.TabIndex = 43;
            this.grpBoxDate.TabStop = false;
            this.grpBoxDate.Text = "Date";
            this.grpBoxDate.Visible = false;
            this.grpBoxDate.Enter += new System.EventHandler(this.grpBoxDate_Enter);
            // 
            // dtgMedicament
            // 
            this.dtgMedicament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMedicament.Location = new System.Drawing.Point(61, 147);
            this.dtgMedicament.Name = "dtgMedicament";
            this.dtgMedicament.Size = new System.Drawing.Size(260, 150);
            this.dtgMedicament.TabIndex = 44;
            this.dtgMedicament.Visible = false;
            this.dtgMedicament.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMedicament_CellContentClick);
            // 
            // BdgSourceOffrir
            // 
            this.BdgSourceOffrir.DataSource = typeof(Mission3.offrir);
            // 
            // FrmModifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 544);
            this.Controls.Add(this.dtgMedicament);
            this.Controls.Add(this.grpBoxDate);
            this.Controls.Add(this.cbxBilan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxMotif);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BdgNavRapport);
            this.Controls.Add(this.grbxVisiteurs);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datepicker);
            this.Name = "FrmModifier";
            this.Text = "Modifiercs";
            this.Load += new System.EventHandler(this.Modifiercs_Load);
            this.grbxVisiteurs.ResumeLayout(false);
            this.grbxVisiteurs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BdgNavRapport)).EndInit();
            this.BdgNavRapport.ResumeLayout(false);
            this.BdgNavRapport.PerformLayout();
            this.grpBoxDate.ResumeLayout(false);
            this.grpBoxDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicament)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BdgSourceOffrir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker datepicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource BdgSourceOffrir;
        private System.Windows.Forms.GroupBox grbxVisiteurs;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxVisiteursPrenom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxVisiteursNom;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.BindingNavigator BdgNavRapport;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxMotif;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxBilan;
        private System.Windows.Forms.GroupBox grpBoxDate;
        private System.Windows.Forms.DataGridView dtgMedicament;
    }
}