using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CabinetMedicalApp.Classes
{
    public partial class FormAccueil : Form
    {
        private Cabinet cabinet = new Cabinet();

        public FormAccueil()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // Vérifications des champs
            if (string.IsNullOrWhiteSpace(txtNom.Text) ||
                string.IsNullOrWhiteSpace(txtPrenom.Text) ||
                string.IsNullOrWhiteSpace(textAdresse.Text) ||
                comboSexe.SelectedItem == null ||
                comboSpe.SelectedItem == null)
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Initialisation des variables
            string adresse = textAdresse.Text;
            DateTime dateNaissance = date.Value;
            string sexe = comboSexe.SelectedItem.ToString();
            string specialite = comboSpe.SelectedItem.ToString();

            // Création du patient
            Patient patient = new Patient(txtNom.Text, txtPrenom.Text, adresse, sexe, dateNaissance, specialite);

            // Ajouter le patient à la liste d'attente
            cabinet.AjouterPatient(patient);

            // Actualiser l'affichage de la liste d'attente
            ActualiserListe();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (lstPatients.SelectedIndex >= 0)
            {
                // Retirer et récupérer le patient en même temps via Cabinet.cs
                var patient = cabinet.supprimerPatient(lstPatients.SelectedIndex);

                if (patient != null)
                {
                    // Remplir la section "Informations sur le Patient"
                    txtNom.Text = patient.Nom;
                    txtPrenom.Text = patient.Prenom;
                    textAdresse.Text = patient.Adresse;
                    comboSexe.Text = patient.Sexe;
                    date.Value = patient.DateNaissance;
                    comboSpe.Text = patient.SpecialiteDemandee;
                }

                // Actualiser la liste
                ActualiserListe();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un patient à retirer.", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReinitialiser_Click(object sender, EventArgs e)
        {
            cabinet = new Cabinet();
            ActualiserListe();
        }

        private void ActualiserListe()
        {
            lstPatients.Items.Clear();
            foreach (var p in cabinet.ListerPatients())
            {
                lstPatients.Items.Add(p);
            }
        }

        private void btnquite_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnfunction_Click(object sender, EventArgs e)
        {
            FormSpécialité form = new FormSpécialité(cabinet);
            form.ShowDialog();
        }

        private void lstPatients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnresetform_Click(object sender, EventArgs e)
        {

            txtNom.Clear();
            txtPrenom.Clear();
            textAdresse.Clear();
            comboSexe.SelectedIndex = -1;
            comboSpe.SelectedIndex = -1;
            date.Value = DateTime.Today;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Remplir comboSexe
            comboSexe.Items.Clear();
            comboSexe.Items.Add("Homme");
            comboSexe.Items.Add("Femme");

            // Remplir comboSpe depuis la propriété Specialites du cabinet
            comboSpe.Items.Clear();
            foreach (var specialite in cabinet.Specialites)
            {
                comboSpe.Items.Add(specialite);
            }
        }

        private void btnage_Click(object sender, EventArgs e)
        {
            FormAge form = new FormAge(cabinet);
            form.ShowDialog();
        }

        private void btnsexe_click(object sender, EventArgs e)
        {
            FormSexe form = new FormSexe(cabinet);
            form.ShowDialog();
        }

        private void btnprio_Click(object sender, EventArgs e)
        {
            if (lstPatients.Items.Count > 0)
            {
                Patient premier = lstPatients.Items[0] as Patient;
                if (premier != null)
                {
                    FormPrioritaire form = new FormPrioritaire(premier);
                    form.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Aucun patient dans la liste.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
