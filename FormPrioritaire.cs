using System;
using System.Windows.Forms;

namespace CabinetMedicalApp.Classes
{
    public partial class FormPrioritaire : Form
    {
        private Patient prioritaire;

        public FormPrioritaire(Patient patient)
        {
            InitializeComponent();
            this.prioritaire = patient;

            ChargerPatient();
        }

        private void ChargerPatient()
        {
            if (prioritaire != null)
            {
                textname.Text = prioritaire.Nom;
                textprenom.Text = prioritaire.Prenom;
                textsexe.Text = prioritaire.Sexe;
                textspec.Text = prioritaire.SpecialiteDemandee;

                // Empêcher l’édition
                textname.ReadOnly = true;
                textprenom.ReadOnly = true;
                textsexe.ReadOnly = true;
                textspec.ReadOnly = true;
            }
        }
    }
}
