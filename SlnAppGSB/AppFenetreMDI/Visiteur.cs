using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFenetreMDI
{
    class Visiteur
    {

        private string matricule;
        private string nom;
        private string prenom;
        private string mdp;
        private string login;
        private string adresse;
        private Localite uneLocalite;
       // private string telephone; 
        private DateTime dateEntree;
        private string codeUnite;
        private string nomUnite;
       // private int prime;


        public Visiteur(string matricule,string nom, string prenom, string login, string mdp, string adresse, Localite uneLocalite,  DateTime dateEntree, string codeUnite, string nomUnite)
        {
            this.matricule = matricule;
            this.nom = nom;
            this.prenom = prenom;
            this.mdp = mdp;
            this.login = login;
            this.adresse = adresse;
            this.uneLocalite = uneLocalite;
            //this.telephone = telephone;
            this.dateEntree = dateEntree;
            this.codeUnite = codeUnite;
            this.nomUnite = nomUnite;
           // this.prime = prime;


        }
        
        

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        


        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        

        public string Mdp
        {
            get { return mdp; }
            set { mdp = value; }
        }
        

        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }
      
        public Localite UneLocalite
        {
            get { return uneLocalite; }
            set { uneLocalite = value; }
        }
        

        public string Telephone
        {
            get { return Telephone; }
            set { Telephone = value; }
        }
        

        public DateTime DateEntree
        {
            get { return dateEntree; }
            set { dateEntree  = value; }
        }
        

        /*public int Prime
        {
            get { return prime; }
            set { prime = value; }
        }*/
        
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

           
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
    }
}
