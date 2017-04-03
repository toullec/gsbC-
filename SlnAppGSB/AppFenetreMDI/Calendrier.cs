using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFenetreMDI
{
    class Calendrier
    {

        private Medecin medecin;
        private Visiteur visiteur;
        private DateTime date1;
        private DateTime date2;
        private DateTime date3;

        public Calendrier(Medecin codeMed, Visiteur matricule, DateTime date1, DateTime date2, DateTime date3)
        {
            this.medecin = codeMed;
            this.visiteur = matricule;
            this.date1 = date1;
            this.date2 = date2;
            this.date3 = date3;
        }


        public Medecin Medecin
        {
            get { return medecin; }
            set { medecin = value; }
        }

        public Visiteur Visiteur
        {
            get { return visiteur; }
            set { visiteur = value; }
        }


        public DateTime Date1
        {
            get { return date1; }
            set { date1 = value; }
        }

        public DateTime Date2
        {
            get { return date2; }
            set { date2 = value; }
        }

        public DateTime Date3
        {
            get { return date3; }
            set { date3 = value; }
        }
        

    }  
}
