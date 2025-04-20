using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CabinetMedicalApp.Classes
{
    public partial class FormAge : Form
    {
        private Cabinet cabinet;

        public FormAge(Cabinet cabinet)
        {
            InitializeComponent();
            this.cabinet = cabinet;
           
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Utilisation de la méthode de tri par catégorie d'âge directement depuis Cabinet
            var categories = cabinet.PatientsParAge();

            lstEnfants.Items.Clear();
            lstAdultes.Items.Clear();

            // Ajouter les enfants à la liste
            foreach (var enfant in categories["Enfant"])
            {
                lstEnfants.Items.Add(enfant);
            }

            // Ajouter les adultes à la liste
            foreach (var adulte in categories["Adulte"])
            {
                lstAdultes.Items.Add(adulte);
            }
        }

        private void lblAdulte_Click(object sender, EventArgs e)
        {

        }
    }
}
