using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFenetreMDI
{
    class Responsable
    {
        private string matricule;
        private string codeUnite;
        private string nomUnite;
        private Visiteur visiteur;
        // private int prime;


         public Responsable(string matricule, string codeUnite, string nomUnite, Visiteur visiteur)
        {
            this.matricule = matricule;
            this.codeUnite = codeUnite;
            this.nomUnite = nomUnite;
            this.visiteur = visiteur;
           // this.prime = prime;


        }
        

        
        public string CodeUnite
        {
            get { return codeUnite; }
            set { codeUnite = value; }
        }
        

        public string NomUnite
        {
            get { return nomUnite; }
            set { nomUnite = value; }
        }


        public string Matricule
        {
            get { return matricule; }
            set { matricule = value; }
        }

           
      

        public Visiteur Visiteur
        {
            get { return visiteur; }
            set { visiteur = value; }
        }

    }
}
