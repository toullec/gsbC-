using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFenetreMDI
{
    class Medecin
    {

        private string codeMed;
        private string nom;
        private string prenom;
        private string adresse;
        private Localite cp;
        private string telephone;
        private string potentiel;
        private int coefficient;
        private string specialite;
        private string etat;

        public Medecin(string codeMed, string nom, string prenom, string adresse, Localite cp, string telephone, string potentiel, int coefficient, string specialite, string etat)
        {

            this.codeMed = codeMed;
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.cp = cp;
            this.telephone = telephone;
            this.potentiel = potentiel;
            this.specialite = specialite;
            this.coefficient = coefficient;
            this.etat = etat;


        }

        public string CodeMed
        {
            get { return codeMed; }
            set { codeMed = value; }

        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }

        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }

        }

        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }

        }

        public Localite Cp
        {
            get { return cp; }
            set { cp = value; }
        }


        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }

        }

        public string Potentiel
        {

            get { return potentiel; }
            set { potentiel = value; }
        }

        public int Coefficient
        {
            get { return coefficient; }
            set { coefficient = value; }
        }


        public string Specialite
        {
            get { return specialite; }
            set { specialite = value; }
        }

        

        public string Etat
        {
            get { return etat; }
            set { etat = value; }

        }

    }
}
