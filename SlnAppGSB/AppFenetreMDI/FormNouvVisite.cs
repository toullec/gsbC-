using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFenetreMDI
{
    public partial class FormNouvVisite : Form
    {
        public FormNouvVisite()
        {
            //initialisation des composants de la fenêtre

            InitializeComponent();

            //parcours de la liste de médecins
            foreach (Medecin medecin in PasserelleOracle.retournerListMedecin())
            {
                //ajout des codemed dans le combox de médecin
                medecinCB.Items.Add(medecin.CodeMed);
                
               
            }

            foreach (Visiteur visiteur in PasserelleOracle.retournerListVisiteur())
            {
                //ajout des matricule dans le combobox visiteur
                visiteurCB.Items.Add(visiteur.Matricule);

            }
        }

        private void validerVisiteBtn_Click(object sender, EventArgs e)
        {
            //validation de la visite

            //conversion de la date pour l'insertion
            DateTime date = DateTime.Parse(dateVisiteTP.Text);

            //création des médecins et visiteurs selon le code renvoyer par les combobox
            Medecin medecin = PasserelleOracle.rechercherMedecin(medecinCB.Text);
            Visiteur visiteur = PasserelleOracle.rechercherVisiteur(visiteurCB.Text);
            Visite visite = new Visite(referenceTB.Text,date,commentaireTB.Text,medecin,visiteur,0);
            //PasserelleOracle.inserer(referenceTB.Text+","+dateVisiteTP+","+commentaireTB+","+medecinCB.Text+","+visiteurCB.Text);
            if (PasserelleOracle.creerVisite(visite) == 1)
            {
                //création de la visite
                MessageBox.Show("ok");
            }
            else
            {
                //erreur dans l'insertion
                DateTime thisDate = new DateTime(05, 05, 03);
                //DateTimeFormatInfo fmt = (new CultureInfo("hr-HR")).DateTimeFormat;
                MessageBox.Show("non"+medecinCB.Text);
                MessageBox.Show("non"+visiteurCB.Text);
                MessageBox.Show("non"+commentaireTB.Text);
                //MessageBox.Show("non"+date.ToString());
                MessageBox.Show("non" + thisDate);
                MessageBox.Show("non"+referenceTB.Text);
            }
        }

        private void FormNouvVisite_Load(object sender, EventArgs e)
        {

        }

        private void medecinCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
