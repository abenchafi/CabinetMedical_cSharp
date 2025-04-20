using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CabinetMedicalApp.Classes
{
    public partial class FormSexe : Form
    {
        private Cabinet cabinet;

        public FormSexe(Cabinet cabinet)
        {
            InitializeComponent();
            this.cabinet = cabinet;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            lstFemme.Items.Clear();
            lstHomme.Items.Clear();

            var femme = cabinet.PatientsParSexe("Femme");
            var homme = cabinet.PatientsParSexe("Homme");

            foreach (var f in femme)
                lstFemme.Items.Add(f);

            foreach (var h in homme)
                lstHomme.Items.Add(h);
        }
    }
}
