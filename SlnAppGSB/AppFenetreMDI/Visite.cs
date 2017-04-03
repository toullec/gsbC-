using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFenetreMDI
{
    class Visite
    {
        private string reference;
        private DateTime date;
        private string commentaire;
        private Medecin unMedecin;
        private Visiteur unVisiteur;
        private int coefficient;
        private Localite uneLocalite;

        public Visite(string reference, DateTime date, string commentaire, Medecin unMedecin, Visiteur unVisiteur, int coefficient)
        {
            this.reference = reference;
            this.date = date;
            this.commentaire = commentaire;
            this.unMedecin = unMedecin;
            this.unVisiteur = unVisiteur;
            this.coefficient = coefficient;
           


        }

        public string Reference
        {

            get { return reference; }
            set{ reference=value;}
        }

        public DateTime Date
        {
            get { return date; }
            set{ date=value;}
        }


        public string Commentaire
        {
            get { return commentaire; }
            set{ commentaire=value;}

        }

        public int Coefficient
        {
            get { return coefficient; }
            set { coefficient = value; }

        }


        public Medecin UnMedecin
        {
            get { return unMedecin; }
            set{ unMedecin=value;}

        }


        public Visiteur UnVisiteur
        {

            get { return unVisiteur; }
            set{ unVisiteur=value;}
        }

        public Localite UneLocalite
        {
            get { return uneLocalite; }
            set { uneLocalite = value; }
        }
        
    }
}
