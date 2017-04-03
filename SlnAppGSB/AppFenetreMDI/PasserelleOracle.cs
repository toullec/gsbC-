using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace AppFenetreMDI
{
    class PasserelleOracle
    {

        public static OracleConnection conn;
        static SqlConnection myConnection;
        static SqlCommand myCommand;
        static string myConnectionString;
        public static string connection;
        public SqlDataAdapter da = new SqlDataAdapter();
        public DataSet ds = new DataSet();
        //ne pas oublier d'enlever con.dispose pour ne pas avoir d'erreur exception
        public static void connexionBase()
        {
            // chaine de connexion
            //string connection = "Data Source=192.168.1.130:1522;User Id=oraproc;Password=password";
            //string connection = "Data Source=192.168.1.52:1522;User Id=oraproc;Password=password";
            connection = "Data Source=192.177.1.17:1521;User Id=simon;Password=password";
            //connection = "Data Source=192.168.60.53:1521;User Id=gsb;Password=password";
            conn = new OracleConnection(connection);
            try
            {
                conn.Open();
                Console.WriteLine("connexion Oracle");
            }
            catch (Exception)
            {
                Console.WriteLine("erreur connexion bd");
            }
        }

        public static OracleDataReader selectionner(string requete)
        {
            //fonction qui permet de faire une sélection de données
            connexionBase();
            OracleDataReader dr = null;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = requete;

            try
            {
                dr = cmd.ExecuteReader();
            }
            catch
            {
                Console.WriteLine("erreur exécution requête : " + requete);
            }
            
            return dr;
        }

        public static void inserer(string requete)
        {
            //fonction qui permet de faire une insertion de données
            connexionBase();
            OracleDataReader dr = null;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = requete;
            try
            {
                dr = cmd.ExecuteReader();
            }
            catch
            {
                Console.WriteLine("erreur exécution requête : " + requete);
            }
            conn.Dispose();

        }

        public static int creerVisite(Visite visite)
        {
            //création d'une visite

            int resultat = 1;
            String value = visite.Date.ToString();
            Char delimiter = '/';
            int dd = int.Parse(value.Split(delimiter)[0]);
            int mm = int.Parse(value.Split(delimiter)[1]);
            //int yy = int.Parse(value.Split(delimiter)[2]);
            DateTime thisDate = new DateTime(dd,mm,03);
            DateTime thisDate2 = new DateTime(2008, 3, 15);
           
            try
            {
                //insertion de la visite
                inserer("INSERT INTO VISITE(" + visite.Reference + ",TO_DATE(" + thisDate2 + ")," + visite.Commentaire + "," + visite.UnMedecin.CodeMed + "," + visite.UnVisiteur.Matricule + "," + 0);


            }
            catch
            {
                
                //erreur
                resultat = 0;
            }


            return resultat;



        }


        public static int affecterResponsable(String visiteur, String responsable)
        {
            int resultat = 1;

            try
            {
                //??????????
                inserer("update RESPONSABLE set visiteur="+visiteur+" where MATRICULE="+responsable+";");


            }
            catch
            {


                resultat = 0;
            }


            return resultat;



        }



        public static Localite rechercherLocalite(string unCode)
        {
            //recherche d'une localité selon le code postal

            //recherche de la locatlité avec la base de données
            Localite uneLocalite = null;
            OracleDataReader dr = selectionner("Select * from localite WHERE CODEPOSTAL='"+unCode+"'");    // where CODEPOSTAL ='" + unCode + "'");
            try
            {
                if (dr.Read())
                {
                    //récupération de la localité avec les valeurs de la base de données
                    uneLocalite = new Localite(dr.GetString(0), dr.GetString(1));
                }
            }
            catch
            {
                //erreur, inexécution de la requête
                Console.WriteLine("Erreur requête : " + "Select * from LOCALITE where CODEPOSTAL ='" + unCode + "'");
            }
            dr.Close();
            conn.Dispose();
            return uneLocalite;
        } 


        public static Visiteur rechercherVisiteur(string matricule)
        {
            //recherche d'un visiteur selon son matricule

            //sélection dans la base de données du visiteur avec son matricule
            Visiteur visiteur = null;
            OracleDataReader dr = selectionner("SELECT * FROM VISITEUR where matricule='"+matricule+"'");    // where CODEPOSTAL ='" + unCode + "'");
            try
            {
                if (dr.Read())
                {
                    //récupération de la localité selon le code postal du visiteur
                    Localite uneLoc = rechercherLocalite(dr.GetString(6));
                    //récupération de la date du visiteur en convertissant un string en datetime
                    DateTime dateEntree = Convert.ToDateTime(dr.GetString(7));
                    //création d'un visiteur avec les données de la base de données
                    visiteur = new Visiteur(dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3),dr.GetString(4),dr.GetString(5),uneLoc,dateEntree,dr.GetString(8),dr.GetString(9));
                }
            }
            catch
            {
                //erreur dans la requête de sélection
                Console.WriteLine("Erreur requête : " + "Select * from VISITEUR where matricule ='" + matricule + "'");
            }
            //dr.Close();
            conn.Dispose();
            return visiteur;
        }





        public static Medecin rechercherMedecin(string code)
        {
            Medecin medecin = null;
            //sélection d'un médecin selon son code
            OracleDataReader dr = selectionner("Select * from MEDECIN where CODEMED='"+code+"'");    // where CODEPOSTAL ='" + unCode + "'");
            try
            {
                if (dr.Read())
                {
                    //création d'une localité avec la recherche d'une localité selon le code postal du médecin
                    Localite uneLoc = rechercherLocalite(dr.GetString(4));
                    //création d'un médein avec la récupération des données de la sélection dans la base
                    medecin = new Medecin(dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), uneLoc, dr.GetString(5), dr.GetString(6), dr.GetInt32(7), dr.GetString(8), dr.GetString(9));
                }
            }
            catch
            {
                //erreur dans la requête de sélection
                Console.WriteLine("Erreur requête : " + "Select * from MEDECIN where CODEMED ='" + code + "'");
            }
            //dr.Close();
            conn.Dispose();
            return medecin;

        }



        



        public static List<Medecin> retournerListMedecin()
        {
            List<Medecin> lesMedecins = new List<Medecin>();
            //sélection dans la base de données de tous les médecins
            OracleDataReader dr = selectionner("Select * from MEDECIN");
            if (dr.HasRows)
            {
                while (dr.Read())
                { // CODEMED NOM PRENOM ADRESSE CODEPOSTAL TELEPHONE POTENTIEL SPECIALITE
                    // Medecin(string codeMed, string nom, string prenom, string adresse, Localite laLocalite, 
                    // string telephone, string potentiel, string specialite)

                    //on parcours tous les médecins de la base de données

                    //on récupère les données de la base pour les affecter aux variables
                    string cod = dr.GetString(0);
                    string nom = dr.GetString(1);
                    string pre = dr.GetString(2);
                    string adr = dr.GetString(3);
                    string cp = dr.GetString(4);
                    Localite uneLoc = rechercherLocalite(cp);
                    string tel = dr.GetString(5);
                    string pot = dr.GetString(6);
                    int coefficient = dr.GetInt32(7);
                    string spe = dr.GetString(8);
                    string etat = dr.GetString(9);

                    //ajout des créations des médecins dans un arraylist de médecins
                    lesMedecins.Add(new Medecin(cod, nom, pre, adr, uneLoc, tel, pot, coefficient, spe, etat));
                }
            }
            else
            {
                //aucune valeurs dans de retounées dans la base de données
                Console.WriteLine("No rows found.");
            }
            dr.Close();
            conn.Dispose();
            return lesMedecins;
        }


        public static List<Visiteur> retournerListVisiteur()
        {
            List<Visiteur> lesVisiteurs = new List<Visiteur>();
            //sélection de tous les visiteur dans la base de données
            OracleDataReader dr = selectionner("Select * from VISITEUR");

            if (dr.HasRows)
            {

                while (dr.Read())
                { // CODEMED NOM PRENOM ADRESSE CODEPOSTAL TELEPHONE POTENTIEL SPECIALITE
                    // Medecin(string codeMed, string nom, string prenom, string adresse, Localite laLocalite, 
                    // string telephone, string potentiel, string specialite)

                    //on parcours tous les visiteurs de la base


                    //récupération des valeurs de la base de données pour les affecter aux variables
                    string cod = dr.GetString(0);
                    string nom = dr.GetString(1);
                    string pre = dr.GetString(2);
                    string login = dr.GetString(3);
                    string mdp = dr.GetString(4);
                    string adresse = dr.GetString(5);
                    Localite uneLoc = rechercherLocalite(dr.GetString(6));
                    DateTime dateEntree = dr.GetDateTime(7);
                    string codeUnit = dr.GetString(8);
                    string nomUnit = dr.GetString(9);
                    // int prime = dr.GetInt16(8);

                    //ajout des créations de visiteurs dans l'arraylist de visiteurs
                    lesVisiteurs.Add(new Visiteur(cod, nom, pre, login, mdp, adresse, uneLoc, dateEntree, codeUnit, nomUnit));
                }
            }
            else
            {
                //aucune valeurs dans de retounées dans la base de données
                Console.WriteLine("No rows found.");
            }
            
            
            dr.Close();
            conn.Dispose();
            return lesVisiteurs;

        }

        public static List<Podium> retournerListPodium()
        {
            List<Podium> lePodium = new List<Podium>();
            OracleDataReader dr = selectionner("Select * from PODIUM");
            //sélection de tous les podium

            if (dr.HasRows)
            {
                while (dr.Read())
                { // CODEMED NOM PRENOM ADRESSE CODEPOSTAL TELEPHONE POTENTIEL SPECIALITE
                    // Medecin(string codeMed, string nom, string prenom, string adresse, Localite laLocalite, 
                    // string telephone, string potentiel, string specialite)

                    // parcours de tous les podium de la base

                    //affectation des variables par les valeurs de la base de données
                    int cod = dr.GetInt32(0);
                    Visiteur visiteur = rechercherVisiteur(dr.GetString(1));
                    int nbVisite = dr.GetInt32(2);
                    int rang = dr.GetInt32(3);

                    // int prime = dr.GetInt16(8);

                    //ajout des podiums dans l'arraylist podium
                    lePodium.Add(new Podium(cod,visiteur, nbVisite, rang));
                }
            }
            else
            {
                //aucune valeurs dans de retounées dans la base de données
                Console.WriteLine("No rows found.");
            }

            dr.Close();
            conn.Dispose();
            return lePodium;

        }





        public static List<Responsable> retournerListResponsable()
        {
            List<Responsable> lesResponsables = new List<Responsable>();
            //sélection des responsables
            OracleDataReader dr = selectionner("Select * from RESPONSABLE");
            if (dr.HasRows)
            {
                while (dr.Read())
                { // CODEMED NOM PRENOM ADRESSE CODEPOSTAL TELEPHONE POTENTIEL SPECIALITE
                    // Medecin(string codeMed, string nom, string prenom, string adresse, Localite laLocalite, 
                    // string telephone, string potentiel, string specialite)

                    //parcours de tous les responsables

                    //affectation des variables avec les données de la sélection
                    string cod = dr.GetString(0);
                    string codeUnit = dr.GetString(1);
                    string nomUnit = dr.GetString(2);
                    Visiteur visiteur = rechercherVisiteur(dr.GetString(3));
                    // int prime = dr.GetInt16(8);

                    //ajout des responsables dans l'arraylist responsable
                    lesResponsables.Add(new Responsable(cod, codeUnit, nomUnit, visiteur));
                }
            }
            else
            {
                //aucune valeur de la base de données trouvées
                Console.WriteLine("No rows found.");
            }
            dr.Close();
            conn.Dispose();
            return lesResponsables;
        }

        public static List<Visite> retournerListVisite()
        {
            List<Visite> lesVisites = new List<Visite>();
            //sélection des visites dans la base de donnée
            OracleDataReader dr = selectionner("Select * from VISITE");
            if (dr.HasRows)
            {
                int i = 0;
                while (dr.Read())
                { // CODEMED NOM PRENOM ADRESSE CODEPOSTAL TELEPHONE POTENTIEL SPECIALITE
                    // Medecin(string codeMed, string nom, string prenom, string adresse, Localite laLocalite, 
                    // string telephone, string potentiel, string specialite)

                    //parcours des visites de la base de données

                    //affectation des variables avec les valeurs de la base de données
                    Console.WriteLine('k'+i);
                    string reference = dr.GetString(0);
                    DateTime dateVisite = dr.GetDateTime(1);
                    string commentaire = dr.GetString(2);
                    /*if(dr.GetString(2)== null){
                        commentaire = "";
                    }else{
                        commentaire = dr.GetString(2);
                    }*/
                    
                    //string commentaire = dr.GetString(2);
                    Visiteur matricule = rechercherVisiteur(dr.GetString(3));
                    Medecin codeMed = rechercherMedecin(dr.GetString(4));
                    int coefficient = 0;
                    i++;

                    //ajout des visites dans l'arraylist de visite
                    lesVisites.Add(new Visite(reference, dateVisite, commentaire, codeMed, matricule,coefficient));
                }
            }
            else
            {
                //aucune valeur trouvée dans la base de données
                Console.WriteLine("No rows found.");
            }
            dr.Close();
            conn.Dispose();
            return lesVisites;
        }

        public static List<Visite> retournerListVisite2(String visiteur)
        {
            List<Visite> lesVisites = new List<Visite>();
            //sélection des visites dans la base de donnée
            OracleDataReader dr = selectionner("Select * from VISITE WHERE MATRICULE='"+visiteur+"'");
            if (dr.HasRows)
            {
                int i = 0;
                while (dr.Read())
                { // CODEMED NOM PRENOM ADRESSE CODEPOSTAL TELEPHONE POTENTIEL SPECIALITE
                    // Medecin(string codeMed, string nom, string prenom, string adresse, Localite laLocalite, 
                    // string telephone, string potentiel, string specialite)

                    //parcours des visites de la base de données

                    //affectation des variables avec les valeurs de la base de données
                    Console.WriteLine('k' + i);
                    string reference = dr.GetString(0);
                    DateTime dateVisite = dr.GetDateTime(1);
                    string commentaire = dr.GetString(2);
                    /*if(dr.GetString(2)== null){
                        commentaire = "";
                    }else{
                        commentaire = dr.GetString(2);
                    }*/

                    //string commentaire = dr.GetString(2);
                    Visiteur matricule = rechercherVisiteur(dr.GetString(3));
                    Medecin codeMed = rechercherMedecin(dr.GetString(4));
                    int coefficient = 0;
                    i++;

                    //ajout des visites dans l'arraylist de visite
                    lesVisites.Add(new Visite(reference, dateVisite, commentaire, codeMed, matricule, coefficient));
                }
            }
            else
            {
                //aucune valeur trouvée dans la base de données
                Console.WriteLine("No rows found.");
            }
            dr.Close();
            conn.Dispose();
            return lesVisites;
        }

        public static List<Podium> retournerLePodium()
        {
            List<Podium> lePodium = new List<Podium>();
            //sélection des podiums
            OracleDataReader dr = selectionner("Select * from PODIUM");
            if (dr.HasRows)
            {
                while (dr.Read())
                { // CODEMED NOM PRENOM ADRESSE CODEPOSTAL TELEPHONE POTENTIEL SPECIALITE
                    // Medecin(string codeMed, string nom, string prenom, string adresse, Localite laLocalite, 
                    // string telephone, string potentiel, string specialite)

                    //parcours de tous les responsables

                    //affectation des variables avec les données de la sélection
                    int id = dr.GetInt32(0);
                    int nbVisite = dr.GetInt32(3);
                    int rang = dr.GetInt32(4);
                    Visiteur visiteur = rechercherVisiteur(dr.GetString(1));
                   

                    //ajout des podium dans l'arraylist podium
                    lePodium.Add(new Podium(id, visiteur,nbVisite, rang));
                }
            }
            else
            {
                //aucune valeur de la base de données trouvées
                Console.WriteLine("No rows found.");
            }
            dr.Close();
            conn.Dispose();
            return lePodium;
        }
       
    }
    
}
