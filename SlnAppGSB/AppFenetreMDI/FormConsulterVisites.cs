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
    public partial class FormConsulterVisites : Form
    {
        private ListViewItem item;
        public FormConsulterVisites()
        {

            //initialisation des composants de la fenêtre
            InitializeComponent();

            foreach (Visiteur visiteur in PasserelleOracle.retournerListVisiteur())
            {
                //ajout des matricule dans le combobox visiteur
                visiteurCB.Items.Add(visiteur.Matricule);

            }
            
           
        }

        private void FormConsulterVisites_Load(object sender, EventArgs e)
        {

        }

        private void lvVisites_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void validerBtn_Click(object sender, EventArgs e)
        {
            //parcours de toutes les visites avec l'arraylist de visite
            foreach (Visite visite in PasserelleOracle.retournerListVisite2(visiteurCB.Text))
            {
                //affichage des visites dans un tableau
                item = new ListViewItem();
                item.Text = visite.Reference;
                item.SubItems.Add(visite.Date.ToString());
                item.SubItems.Add(visite.Commentaire);
                item.SubItems.Add(visite.UnMedecin.CodeMed);
                item.SubItems.Add(visite.UnVisiteur.Matricule);
                item.SubItems.Add(visite.UneLocalite.Ville);
                lvVisites.Items.Add(item);
                lvVisites.Size = new Size(400, 200);

            }
        }
    }
}
