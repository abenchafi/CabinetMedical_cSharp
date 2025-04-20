using System;
using System.Windows.Forms;
using CabinetMedicalApp.Classes;

namespace CabinetMedicalApp
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormAccueil form = new FormAccueil();
            form.Size = new System.Drawing.Size(800, 600); // Spécifie la taille de la fenêtre ici
            Application.Run(form);
        }
    }
}
