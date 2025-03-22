using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Serialization;
using System.Text.Json;
using Newtonsoft.Json;

namespace Mission3
{
    public partial class FrmVisualiser : Form
    {
        private Gsb2023Entities1 mesDonneesGSB;
        public FrmVisualiser(Gsb2023Entities1 mesDonneesGSB)
        {

            InitializeComponent();
            this.mesDonneesGSB = new Gsb2023Entities1();
        }


        public class RapportDTO
        {
            public int Id { get; set; }
            public DateTime Date { get; set; }
            public string IdVisiteur { get; set; }
            public int IdMedecin { get; set; }
            public string Motif { get; set; }
            public string Bilan { get; set; }

            public string idMedicament { get; set; }
            public int quantite { get; set; } 
            
            public string Famille { get; set; }
            public string nomMedecin {get; set; }

            public string prenomMedecin { get; set; }

            public string nomVisiteur { get; set; }
            public string prenomVisiteur { get; set; }
            public string nomCommercial { get; set; }
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

        private void LoadVisiteurPrenom(string nom)
        {
            var visiteurs = mesDonneesGSB.visiteurs
                            .Where(v => v.nom == nom)
                             .Select(v => new { v.prenom, v.id })
                             .ToList();

            cbxVisiteursPrenom.Items.Clear();
            cbxVisiteursPrenom.SelectedIndex = -1;
            cbxVisiteursPrenom.ResetText();

            foreach (var v in visiteurs)
            {
                Debug.WriteLine(v.prenom);
                cbxVisiteursPrenom.Items.Add(v.prenom);
                cbxVisiteursPrenom.ValueMember = v.id;




            }
            cbxVisiteursPrenom.Visible = true;

        }
        private void FrmVisualiser_Load(object sender, EventArgs e)
        {
            cbxVisiteursPrenom.Visible = false;

            LoadVisiteursNom();


        }

        private void cbxVisiteursNom_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nom = cbxVisiteursNom.Text.ToString();
         

            LoadVisiteurPrenom(nom);


        }

        private string idVisiteur(string nom, string prenom)
        {
            var requete = mesDonneesGSB.visiteurs
                          .Where(v => v.nom == nom && v.prenom == prenom)
                          .Select(v => v.id).FirstOrDefault();

          

            return requete;

        }

        private List<RapportDTO> ShowRapports(string idVisiteur, DateTime date)
        {
            var rapportsSelectifs =
            (from rapport in mesDonneesGSB.rapports
             join offrir in mesDonneesGSB.offrirs on rapport.id equals offrir.idRapport
             join medicament in mesDonneesGSB.medicaments on offrir.idMedicament equals medicament.id
             join medecin in mesDonneesGSB.medecins on rapport.idMedecin equals medecin.id
             join visiteur in mesDonneesGSB.visiteurs on rapport.idVisiteur equals visiteur.id

             where rapport.idVisiteur == idVisiteur && rapport.date == date
             select new RapportDTO
             {
                 Id = rapport.id,
                 Date = rapport.date.Value,
                 IdVisiteur = rapport.idVisiteur,
                 IdMedecin = rapport.idMedecin,
                 Motif = rapport.motif,
                 Bilan = rapport.bilan,
                 quantite = (int)offrir.quantite,
                 idMedicament = medicament.id,
                 Famille = medicament.idFamille,
                 nomCommercial = medicament.nomCommercial,
                 nomMedecin = medecin.nom,
                 prenomMedecin = medecin.prenom,
                 prenomVisiteur = visiteur.prenom,
                 nomVisiteur = visiteur.nom,
                 



             }).ToList();

                return rapportsSelectifs;
      


         

        }

        private void GenererFichierJSON(List<RapportDTO> rapports)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Fichiers JSON (*.json)|*.json",
                Title = "Enregistrer le fichier JSON"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string cheminFichier = saveFileDialog.FileName;

                // Sérialiser les rapports en JSON
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true // Rendre le JSON lisible
                };

                //string json = JsonSerializer.Serialize(rapports, options);
                        string json = JsonConvert.SerializeObject(rapports,
            Formatting.Indented,
            new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects
            });

                // Écrire dans le fichier
                File.WriteAllText(cheminFichier, json);

                MessageBox.Show($"Fichier JSON généré : {cheminFichier}");
            }
        }


  
        private void btnGenererXml_Click(object sender, EventArgs e)
        {
            string prenom = cbxVisiteursPrenom.Text.ToString();
            string nom = cbxVisiteursNom.Text.ToString();
            DateTime date = dateTimePicker1.Value.Date;
            if (prenom != null && nom != null && date != null)
            {
                try
                {
                    string id = idVisiteur(nom, prenom);

                    List<RapportDTO> lesRapports = ShowRapports(id, date);
                    MessageBox.Show(lesRapports.Count().ToString());

                    if (lesRapports == null || lesRapports.Count == 0)
                    {
                        Console.WriteLine("La liste des rapports est vide. Aucun fichier JSON ne sera généré.");
                        return;
                    }

                    GenererFichierJSON(lesRapports);

                   

                }


                catch (Exception ex)
                {

                    MessageBox.Show( $"{ex}");
                }

            }

            else
            {
                MessageBox.Show("Veuillez remplir les informations  !!! ");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}
