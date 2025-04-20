using System;
using System.Collections.Generic;
using System.Linq;

namespace CabinetMedicalApp.Classes
{
    public class Cabinet
    {
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public List<string> Specialites { get; set; }
        public List<Patient> Patients { get; set; }

        // Constructeur sans paramètre
        public Cabinet()
        {
            Nom = "Cabinet Médical";
            Adresse = "Adresse non définie";
            Specialites = new List<string> { "Généraliste", "Dentiste", "Cardiologue" };
            Patients = new List<Patient>();
        }

        // Constructeur avec paramètres
        public Cabinet(string nom, string adresse, List<string> specialites = null)
        {
            Nom = nom;
            Adresse = adresse;
            Specialites = specialites ?? new List<string> { "Généraliste", "Dentiste", "Cardiologue" };
            Patients = new List<Patient>();
        }

        public override string ToString()
        {
            return $"Cabinet : {Nom}\nAdresse : {Adresse}\nSpécialités : {string.Join(", ", Specialites)}\nNombre de patients : {Patients.Count}";
        }

        // Ajouter une spécialité
        public void AjouterSpecialite(string specialite)
        {
            if (!Specialites.Contains(specialite))
                Specialites.Add(specialite);
        }

        // Ajouter un patient (par objet)
        public void AjouterPatient(Patient p) => Patients.Add(p);


        // Ajouter un ensemble de patients
        public void AjouterPatients(IEnumerable<Patient> patients)
        {
            Patients.AddRange(patients);
        }

        // Supprimer un patient (par objet)
        public Patient supprimerPatient(int index)
        {
            if (index >= 0 && index < Patients.Count)
            {
                var patient = Patients[index];
                Patients.RemoveAt(index);
                return patient;
            }
            return null;
        }

        // Chercher un patient par objet
        public bool ChercherPatient(Patient p) =>
            Patients.Contains(p);

        
        // Liste des patients par sexe
        public List<Patient> PatientsParSexe(string sexe) =>
            Patients.Where(p => p.Sexe.Equals(sexe, StringComparison.OrdinalIgnoreCase)).ToList();


        // Liste des patients par spécialité demandée
        public List<Patient> PatientsParSpecialiste(string specialite) =>
            Patients.Where(p => p.SpecialiteDemandee.Equals(specialite, StringComparison.OrdinalIgnoreCase)).ToList();

        // Liste des patients classés par catégorie d'âge
        public Dictionary<string, List<Patient>> PatientsParAge()
        {
            var categories = new Dictionary<string, List<Patient>>
            {
                { "Enfant", new List<Patient>() },
                { "Adulte", new List<Patient>() }
            };

            foreach (var patient in Patients)
            {
                int age = DateTime.Now.Year - patient.DateNaissance.Year;
                if (patient.DateNaissance > DateTime.Now.AddYears(-age)) age--;

                if (age < 18)
                {
                    categories["Enfant"].Add(patient);
                }
                else
                {
                    categories["Adulte"].Add(patient);
                }
            }

            return categories;
        }

        // Lister tous les patients
        public List<Patient> ListerPatients()
        {
            return Patients;
        }

        // Patient prioritaire (le premier enregistré dans le système)
        public Patient PatientPrioritaire() =>
            Patients.FirstOrDefault();
    }
}
