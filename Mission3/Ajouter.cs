using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mission3
{

    /**** Trigger ajouter 
     * 
     * CREATE TRIGGER BeforeInsertRapport
        ON rapport
        INSTEAD OF INSERT
        AS
        BEGIN
            -- Vérifier l'existence d'un rapport avec les mêmes caractéristiques
            IF EXISTS (
                SELECT 1
                FROM rapport r
                INNER JOIN INSERTED i ON r.date = i.date
                                      AND r.idVisiteur = i.idVisiteur
                                      AND r.idMedecin = i.idMedecin
            )
            BEGIN
                -- Lever une erreur si un duplicata est trouvé
                THROW 50001, 'Un rapport avec les mêmes caractéristiques existe déjà.', 1;
            END
        END;
    */



    public partial class lblAdresse : Form
    {
        private Gsb2023Entities1 mesDonnesGSB;
        public lblAdresse(Gsb2023Entities1 mesDonnesGSB)
        {

            InitializeComponent();
            this.mesDonnesGSB = mesDonnesGSB;


            var requeteMedecin = from md in mesDonnesGSB.medecins
                                 orderby md.nom
                                 select new
                                 {
                                     Id = md.id,
                                     Nom = md.nom,
                                     Prenom = md.prenom,

                                 };
            var requeteVisiteur = from v in mesDonnesGSB.visiteurs
                                  orderby v.id
                                  select new
                                  {
                                      id = v.id,
                                      nom = v.nom,
                                      prenom = v.prenom,
                                  };
            var requeteMedicament = from m in mesDonnesGSB.medicaments

                                    select new
                                    {
                                        id = m.id,

                                    };

            var bilansDistincts = mesDonnesGSB.rapports
              .Select(m => m.bilan)
              .Distinct()
              .ToList();

            // Liste distincte pour les motifs
            var motifsDistincts = mesDonnesGSB.rapports
                .Select(m => m.motif)
                .Distinct()
                .ToList();

            // Remplissage des ComboBox
            cbxBilan.DataSource = bilansDistincts;
            cbxMotif.DataSource = motifsDistincts;


            cbxMedecinPrenom.Enabled = false;
            cbxVisiteursPrenom.Enabled = false;

            //var nomDistincts = requeteMedecin.Distinct().ToList();
            foreach (var r in requeteMedecin.Distinct().ToList())
            {

                cbxMedecinNom.Items.Add(r.Nom);

            }

            foreach (var v in requeteVisiteur.Distinct().ToList())
            {
                cbxVisiteursNom.Items.Add(v.nom);

            }

            foreach (var m in requeteMedicament.Distinct().ToList())
            {
                cbxMedicament.Items.Add(m.id);
            }

            for (int i = 1; i <= 5; i++)
            {
                cbxQuantite.Items.Add(i);
            }

        }

    
        /*

        private void NombreDeMedicamentOffert (int nbr)

        {
            for (int i = 0; i < nbr; i++)
            {
                GroupBox groupBox = new GroupBox
                {
                    Name = grpOffert.Name + $"{i}",
                    Text = $"Médicament  Offert {i}",
                    Width = 300,
                    Height = 150,
                    Margin = new Padding(10)
                };

                ComboBox cbxMedicament2 = new ComboBox
                {
                    Name = cbxMedicament.Name + $"{i}",
                    Width = 200,
                    Location = new Point(20, 30),
                    DataSource = mesDonnesGSB.medicaments.Select(m => m.id).ToList() // Liste des médicaments
                };
                ComboBox quantite2 = new ComboBox
                {
                    Name = cbxQuantite.Name + $"{i}",
                    Width = 200,
                    Location = new Point(20, 30),

                };

                quantite2.Items.AddRange(Enumerable.Range(1, 10).Cast<object>().ToArray());
                groupBox.Controls.Add(cbxQuantite);

                // Ajouter le GroupBox au FlowLayoutPanel
                FlowLayoutMedicament.Controls.Add(groupBox);
            }

        }
        */
        private bool VerificationDoublonsRapports(string idVisiteur, int IdMedecin, DateTime date)
        {
            bool flag = false;
            var requete = mesDonnesGSB.rapports
                           .Where(r => r.idVisiteur == idVisiteur && r.idMedecin == IdMedecin && r.date == date.Date )
                           .Select(r => r.id).ToList();
            if (requete.Count > 0)
            {
                flag = true;
            }

            return flag;


        }

        private string getIdVisiteur(string nom, string prenom)
        {
            var request = from v in mesDonnesGSB.visiteurs
                          where v.nom == nom && v.prenom == prenom
                          select v.id;


            var id = request.FirstOrDefault();

            Debug.WriteLine(id);

            return id;



        }


        private int getIdMedecin(string nom, string prenom)
        {
            var id = (from m in mesDonnesGSB.medecins
                      where m.nom == nom && m.prenom == prenom
                      select m.id).FirstOrDefault();
            return id;
        }

        private int getIdRapport()
        {
            var request = from r in mesDonnesGSB.rapports
                          orderby r.id descending
                          select r.id;

            int dernierId = request.FirstOrDefault();
            return dernierId + 1;
        }

        private rapport newRapport()
        {
            rapport newRapport = new rapport();
            var prenomVisiteur = cbxVisiteursPrenom.Text;
            var nomVisisteur = cbxVisiteursNom.Text;
            var prenomMedecin = cbxMedecinPrenom.Text;
            var nomMedecin = cbxMedecinNom.Text;



            newRapport.date = dateTimePicker1.Value;
            newRapport.idVisiteur = getIdVisiteur(nomVisisteur, prenomVisiteur);
            newRapport.id = getIdRapport();
            newRapport.bilan = cbxBilan.Text;
            newRapport.motif = cbxMotif.Text;

            
            if (cmbId.Visible == false)
            {
                newRapport.idMedecin = getIdMedecin(nomMedecin, prenomMedecin);
                
            }
            else
            {
                newRapport.idMedecin = Convert.ToInt32(cmbId.Text);
            }
            
            return newRapport;
        }

        private offrir newOffrir(int Idrapport)
        {
            offrir NewOffrirs = new offrir();

            NewOffrirs.quantite = Convert.ToInt32(cbxQuantite.SelectedItem);
            NewOffrirs.idMedicament = cbxMedicament.SelectedItem.ToString();
          
 

            NewOffrirs.idRapport = Idrapport;

            return NewOffrirs;

        }

        private void Ajouter_Load(object sender, EventArgs e)
        {

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {


            try /*********************    NE PAS UTILISER DE TRIGGER !!!!!!!!!!!!!!!!!!!! ************************ */
            {

                this.mesDonnesGSB.rapports.Add(newRapport());
                string idVisiteur = newRapport().idVisiteur;
                int IdMedecin = newRapport().idMedecin;
                DateTime date = newRapport().date.Value;
                if (cbxMedicament.SelectedItem != null)
                {
                    var idRapport = newRapport().id;
                    var offrir = newOffrir(idRapport);
                    Debug.WriteLine($"Offrir : IdRapport={offrir.idRapport}, IdMedicament={offrir.idMedicament}, Quantite={offrir.quantite}");
                    this.mesDonnesGSB.offrirs.Add(newOffrir(idRapport));
                }
                if(!VerificationDoublonsRapports(idVisiteur,IdMedecin, date))
                {
                    this.mesDonnesGSB.SaveChanges();
                    MessageBox.Show("Enregistrement Validé");
                }
                else
                {
                    MessageBox.Show("Il existe déjà un rapport avec ces mêmes informations ! ");
                }
                
               
            }

            catch (DbUpdateException dbEx)
            {
                foreach (var entity in mesDonnesGSB.ChangeTracker.Entries())
                {
                    Debug.WriteLine($"{entity.Entity.GetType().Name} - {entity.State}");
                }
                MessageBox.Show($"{newRapport().id}");
                MessageBox.Show($"Erreur lors de l'enregistrement : {dbEx.Message}\nDétails : {dbEx.InnerException?.Message}",
            "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }

        private void cbxMedicament_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbxMedicament.SelectedItem != null)
            {
                cbxQuantite.Enabled = true; // Active le ComboBox Quantité
            }
            else
            {
                cbxQuantite.Enabled = false; // Désactive le ComboBox Quantité si aucun élément n'est sélectionné
            }

        }

        private void cbxQuantite_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void cbxMedecin_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (cbxMedecinNom.SelectedItem != null)
            {
                string nom = cbxMedecinNom.SelectedItem.ToString();

                var requeteMedecinPrenom = from md in mesDonnesGSB.medecins
                                           orderby md.nom
                                           where md.nom == nom
                                           select new
                                           {
                                               Prenom = md.prenom
                                           };
                cbxMedecinPrenom.Items.Clear();

                cbxMedecinPrenom.SelectedIndex = -1;
                cbxMedecinPrenom.ResetText();
                foreach (var p in requeteMedecinPrenom.Distinct())
                {
                    cbxMedecinPrenom.Items.Add(p.Prenom);
                }


                cbxMedecinPrenom.Enabled = true;


            }



        }

        private void cbxMedecinPrenom_SelectedIndexChanged(object sender, EventArgs e)
        {
            var requeteAdresse = from a in mesDonnesGSB.medecins
                                 where a.nom == cbxMedecinNom.SelectedItem.ToString() && a.prenom == cbxMedecinPrenom.SelectedItem.ToString()
                                 select new
                                 {
                                     id = a.id,
                                 };
            if (requeteAdresse.Count() > 1)
            {
                cmbId.Visible = true;
                cmbId.Items.Clear();
                lblMessage.Visible = true;
                lblId.Visible = true;

                cmbId.SelectedIndex = -1;
                cmbId.ResetText();

                foreach (var p in requeteAdresse)

                {
                    cmbId.Items.Add(p.id);
                }

            }

            else
            {
                cmbId.Visible = false;
                lblMessage.Visible = false;
                lblId.Visible = false;
                cmbId.Items.Clear();
                cmbId.SelectedIndex = -1;
                cmbId.ResetText();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbxVisiteursNom_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbxVisiteursNom.SelectedItem != null)
            {
                string nom = cbxVisiteursNom.SelectedItem.ToString();

                var requeteVisiteurPrenom = from v in mesDonnesGSB.visiteurs
                                            orderby v.nom
                                            where v.nom == nom
                                            select new
                                            {
                                                Prenom = v.prenom,
                                            };
                cbxVisiteursPrenom.Items.Clear();
                cbxVisiteursPrenom.SelectedIndex = -1;
                cbxVisiteursPrenom.ResetText();
                foreach (var p in requeteVisiteurPrenom)
                {
                    cbxVisiteursPrenom.Items.Add(p.Prenom);
                }

                cbxVisiteursPrenom.Enabled = true;


            }


        }


        private void btnValiderMedicament_Click(object sender, EventArgs e)
        {
            /*
            if (nbrMedicament.Value != 0)
            {
                int nombreMedicament = (int)nbrMedicament.Value;
                btnValiderMedicament.Visible = false;
                nbrMedicament.Visible = false;
                lblNbrMedicamament.Visible = false;


                //FlowLayoutMedicament.Visible = true;
                NombreDeMedicamentOffert(nombreMedicament);

            }
            */
        }























        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblNbrMedicamament_Click(object sender, EventArgs e)
        {

        }

     
    }
}
