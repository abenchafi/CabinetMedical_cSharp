using System;

namespace CabinetMedicalApp.Classes
{
    public class Patient
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string Sexe { get; set; }
        public DateTime DateNaissance { get; set; }
        public string SpecialiteDemandee { get; set; }

        // Constructeur sans param�tres
        public Patient() { }

        // Constructeur avec param�tres
        public Patient(string nom, string prenom, string adresse, string sexe, DateTime dateNaissance, string specialiteDemandee)
        {
            Nom = nom;
            Prenom = prenom;
            Adresse = adresse;
            Sexe = sexe;
            DateNaissance = dateNaissance;
            SpecialiteDemandee = specialiteDemandee;
        }

        // M�thode ToString()
        public override string ToString()
        {
            return $"{Nom} {Prenom} - {SpecialiteDemandee}";
        }
    }
}
