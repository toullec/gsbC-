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
    public partial class FormListeVisiteurs : Form
    {
        private ListViewItem item;
        public FormListeVisiteurs()
        {
            //initialisation des composants de la fenêtre

            InitializeComponent();

            //parcours de l'arraylist des visiteurs
            foreach (Visiteur unVisiteur in PasserelleOracle.retournerListVisiteur())
            {
                //affecte les valeurs des colones et affiche ces valeurs dans un tableau de visiteurs
                item = new ListViewItem();
                item.Text = unVisiteur.Matricule;
                item.SubItems.Add(unVisiteur.Nom);
                item.SubItems.Add(unVisiteur.Prenom);
                item.SubItems.Add(unVisiteur.Adresse);
                item.SubItems.Add(unVisiteur.UneLocalite.CodePostal);
                item.SubItems.Add(unVisiteur.UneLocalite.Ville);
                lvVisiteurs.Items.Add(item);
                lvVisiteurs.Size = new Size(400, 200);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            


        }

        private void FormListeVisiteurs_Load(object sender, EventArgs e)
        {

        }
    }
}
