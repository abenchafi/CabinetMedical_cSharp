using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CabinetMedicalApp.Classes
{
    public partial class FormSpécialité : Form
    {
        private Cabinet cabinet;

        public FormSpécialité(Cabinet cabinet)
        {
            InitializeComponent();
            this.cabinet = cabinet;
            AfficherPatientsParSpecialite();
        }

        private void AfficherPatientsParSpecialite()
        {
            listBoxGeneraliste.Items.Clear();
            listBoxDentiste.Items.Clear();
            listBoxCardiologue.Items.Clear();

            // Utilisation de la méthode PatientsParSpecialiste
            var generalistes = cabinet.PatientsParSpecialiste("Généraliste");
            var dentistes = cabinet.PatientsParSpecialiste("Dentiste");
            var cardiologues = cabinet.PatientsParSpecialiste("Cardiologue");

            // Ajouter les patients par spécialité
            foreach (var patient in generalistes)
                listBoxGeneraliste.Items.Add($"{patient.Nom} {patient.Prenom}");

            foreach (var patient in dentistes)
                listBoxDentiste.Items.Add($"{patient.Nom} {patient.Prenom}");

            foreach (var patient in cardiologues)
                listBoxCardiologue.Items.Add($"{patient.Nom} {patient.Prenom}");
        }

    }
}
