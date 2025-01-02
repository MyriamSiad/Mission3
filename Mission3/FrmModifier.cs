using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mission3
{

    /* trigger 
             * CREATE TRIGGER AfterDeleteRapport
        ON rapport
        FOR DELETE
        AS
        BEGIN
            DELETE FROM offrirs
            WHERE idRapport IN (SELECT id FROM DELETED);
        END; ******/
    public partial class FrmModifier : Form
    {


        private Gsb2023Entities1 mesDonneesGSB;
        private BindingSource rapportBindingSource = new BindingSource();
        private BindingSource offrirBindingSource = new BindingSource();
        public FrmModifier(Gsb2023Entities1 mesDonneesGSB)
        {
            this.mesDonneesGSB = mesDonneesGSB;
            InitializeComponent();
            button2.Visible = false;

            cbxVisiteursPrenom.Enabled = false;
            LoadVisiteursNom();

        }

        private void LoadVisiteursNom()
        {
            var visiteurs = mesDonneesGSB.visiteurs
                              .Select(v => new { v.nom })
                              .Distinct().ToList();

            foreach (var v in visiteurs)
            {
                cbxVisiteursNom.Items.Add(v.nom);
            }
        }

        private void ShowAfterComponent()
        {
            txtId.Visible = true;
            label1.Visible = true;
           dtgMedicament.Visible = true;
            dtgMedicament.Rows[0].Cells["idMedicament"].ReadOnly = true;
            lbldate.Visible = true;
            btnEnregistrer.Visible = true;
            label7.Visible = true;
            cbxMotif.Visible = true;
            cbxBilan.Visible = true;
            grpBoxDate.Visible = true;



        }

        private void HideBeforeComponent()
        {
            datepicker.Visible = false;
            grbxVisiteurs.Visible = false;
            button2.Visible = false;
        }
        private void LoadComboBoxData()
        {
            // Charger les valeurs pour "Motif"
            var motifs = mesDonneesGSB.rapports.Select(m => m.motif).Distinct().ToList(); // Exemple : table "motifs"
            cbxMotif.DataSource = motifs; // Associe les motifs à la ComboBox

            // Charger les valeurs pour "Bilan"
            var bilans = mesDonneesGSB.rapports.Select(b => b.bilan).Distinct().ToList(); // Exemple : table "bilans"
            cbxBilan.DataSource = bilans; // Associe les bilans à la ComboBox
        }


        

        private bool ShowReport(string visiteurId, DateTime date)
        {
            bool flag = false;
            // Recherche les rapports pour ce visiteur et cette date
            var rapports = mesDonneesGSB.rapports
             .Where(r => r.idVisiteur == visiteurId && r.date == date)
             .ToList(); // Liste des rapports directement depuis la base de données

          
       

            var rapportsAvecOffres = rapports.Select(rapport => new
            {
                Rapport = rapport,
                Offres = mesDonneesGSB.offrirs.Where(r => r.idRapport == rapport.id).ToList()
            }).ToList();

            // Associe la liste des rapports au BindingSource
        


            // Associe le BindingSource au BindingNavigator
            rapportBindingSource.DataSource = rapportsAvecOffres;
            BdgNavRapport.BindingSource = rapportBindingSource;

            // Lie les données aux contrôles
            txtId.DataBindings.Clear();
            cbxMotif.DataBindings.Clear();
            cbxBilan.DataBindings.Clear();
            lbldate.DataBindings.Clear();

            txtId.DataBindings.Add("Text", rapportBindingSource, "Rapport.id");
            cbxMotif.DataBindings.Add("Text", rapportBindingSource, "Rapport.motif");
            cbxBilan.DataBindings.Add("Text", rapportBindingSource, "Rapport.bilan");
            lbldate.DataBindings.Add("Text", rapportBindingSource, "Rapport.date");

            // Si des médicaments sont offerts, lier les données correspondantes
            dtgMedicament.DataSource = null;
            dtgMedicament.Rows.Clear();

            // Préparez une source de données pour les médicaments
            var medicamentBindingSource = new BindingSource();
            medicamentBindingSource.DataSource = rapportBindingSource;
            medicamentBindingSource.DataMember = "Offres"; // Lien entre rapport et ses offres

            dtgMedicament.DataSource = medicamentBindingSource;

            // Configuration des colonnes du DataGridView
           
            dtgMedicament.AutoGenerateColumns = false;
            dtgMedicament.Columns.Clear();

            dtgMedicament.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Médicament",
                DataPropertyName = "idMedicament",
                Name = "idMedicament"
            });

            dtgMedicament.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Quantité",
                DataPropertyName = "quantite",
                Name = "quantite"
            });

            


            if (rapports.Count > 0)
            {
                
                flag = true;
            }

            return flag;

            

           
        }

        private offrir newOffrir(int Idrapport, int quantite, string idMedicament)
        {
            offrir NewOffrirs = new offrir();

            NewOffrirs.quantite = quantite;
            NewOffrirs.idMedicament = idMedicament;



            NewOffrirs.idRapport = Idrapport;

            mesDonneesGSB.offrirs.Add(NewOffrirs);

            return NewOffrirs;

        }
        private void DataGridViewMedicament(int idRapport)
        {
            var requete = mesDonneesGSB.offrirs
                          .Select(m => new
                          {
                              idMedicament = m.idMedicament,
                              quantite = m.quantite,
                              
                          }).Distinct().ToList();


            dtgMedicament.Columns.Clear();
            dtgMedicament.Columns.Add("IdMedicament", "ID Médicament");

            dtgMedicament.Columns.Add("Quantite", "Quantité");
            foreach (var item in requete)
            {
                dtgMedicament.Rows.Add(item.idMedicament);
                dtgMedicament.Rows.Add((int)item.quantite);
            }
        }


        private bool DataGridViewMedicamentQuantite(int idRapport)
        {
            var requete = mesDonneesGSB.medicaments
                          .Select(m => new
                          {
                              idMedicament = m.id
                              
                          }).Distinct().ToList();
           
            bool flag = false;

            for (int i = 0; i < dtgMedicament.Rows.Count; i++)
            {
                int Quantite = Convert.ToInt32((dtgMedicament.Rows[i].Cells[1].Value));
                if (Quantite > 0)
                {
                    string idMedicament = dtgMedicament.Rows[i].Cells[0].Value.ToString();
                    newOffrir(idRapport, Quantite, idMedicament);

                    flag = true;
                }

            }

            return flag;
        }

        private void Modifiercs_Load(object sender, EventArgs e)
        {
            LoadComboBoxData();
          
    
        }





        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        private void button2_Click(object sender, EventArgs e)
        {
            if (cbxVisiteursNom.SelectedItem != null && datepicker.Value != null && cbxVisiteursPrenom.SelectedItem != null)
            {
                try
                {


                    var prenom = cbxVisiteursPrenom.SelectedItem.ToString();

                    var idVisiteur = mesDonneesGSB.visiteurs
                          .Where(v => v.nom == cbxVisiteursNom.SelectedItem.ToString() && v.prenom == prenom)

                          .Select(v => new
                          {

                             
                              Id = v.id
                          })
                         .FirstOrDefault();

                    var date = datepicker.Value.Date;

                    
                    if (ShowReport(idVisiteur.Id, date) == true)
                    {
                        // Afficher les rapports après avoir trouvé les données

                        HideBeforeComponent();

                        ShowAfterComponent();

                    }
                    else
                    {
                        MessageBox.Show("Visiteur non trouvé.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur : {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un visiteur et une date.");
            }
        }


        private void cbxVisiteursNom_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Visible = true;

            var prenom = mesDonneesGSB.visiteurs
                           .Where(v => v.nom == cbxVisiteursNom.SelectedItem.ToString())

                           .Select(v => new
                           {
                                
                               prenom = v.prenom,
                               Id = v.id
                           })
                          .ToList();

            
            cbxVisiteursPrenom.Items.Clear();
            cbxVisiteursPrenom.SelectedIndex = -1;
            cbxVisiteursPrenom.ResetText();
            foreach (var v in prenom)
            {
                cbxVisiteursPrenom.Items.Add(v.prenom);
                cbxVisiteursPrenom.ValueMember = v.Id;
                

                cbxVisiteursPrenom.Enabled = true;

            }
            button2.Visible = true;
        }

        private void datepicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void grpBoxDate_Enter(object sender, EventArgs e)
        {

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
          
            List<rapport> rapports = new List<rapport>();

            foreach (var item in rapportBindingSource)
            {
               

                this.mesDonneesGSB.SaveChanges();

                MessageBox.Show("Modifications enregistrées avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
    
            }



        }

        private void BdgNavRapport_RefreshItems(object sender, EventArgs e)
        {
          
        }

        private void RefreshData()
        {
            // Recharge les données à partir de la base de données
            var rapports = mesDonneesGSB.rapports.ToList();
            rapportBindingSource.DataSource = rapports;

            // Force la mise à jour des contrôles
            this.Update();
            this.Refresh();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            //var rapport = (rapport)rapportBindingSource.Current;


            var currentItem = rapportBindingSource.Current;

            if (currentItem != null)
            {
                // Accéder à l'objet 'rapport' dans l'objet complexe
                var rapport = ((dynamic)currentItem).Rapport;

                if (rapport != null)
                {
                    // Traitement du rapport, suppression, etc.
                    mesDonneesGSB.rapports.Remove(rapport);
                    mesDonneesGSB.SaveChanges();
                    if (rapportBindingSource.Contains(currentItem))
                    {
                        rapportBindingSource.Remove(currentItem);
                    }
                    this.Update();

                  
                }
                MessageBox.Show("Le rapport a été supprimé avec succès.");

            }
            
            

           

        }

        private void dtgMedicament_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

