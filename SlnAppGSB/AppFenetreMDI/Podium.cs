using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFenetreMDI
{
    class Podium
    {

        private int id;
        private string nom;
        private string prenom;
        private int nbVisite;
        private Visiteur visiteur;
        private int rang;

         public Podium(int id,Visiteur visiteur, int nbVisite,int rang)
        {
            this.id = id;     
            this.nbVisite = nbVisite;
            this.visiteur = visiteur;
            this.rang = rang;
            


        }
        


        public int Id
        {
            get { return id; }
            set { id = value; }
        }


  
        public int NbVisite
        {
            get { return nbVisite; }
            set { nbVisite = value; }
        }

        public int Rang
        {
            get { return rang; }
            set { rang = value; }
        }

        public Visiteur Visiteur
        {
            get { return visiteur; }
            set { visiteur = value; }
        }
    }
}
