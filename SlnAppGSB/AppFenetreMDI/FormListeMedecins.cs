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
    public partial class FormListeMedecins : Form
    {
        private ListViewItem item;
        public FormListeMedecins()
        {
            //initialisation des composants de la fenêtre
            InitializeComponent();

            //parcours de l'arraylist de médecins
            foreach (Medecin medecin in PasserelleOracle.retournerListMedecin())
            {
                //affichage des valeurs du tableau de visites
                item = new ListViewItem();
                item.Text = medecin.CodeMed;
                item.SubItems.Add(medecin.Nom);
                item.SubItems.Add(medecin.Prenom);
                //item.SubItems.Add(medecin.Specialite);
                item.SubItems.Add(medecin.Adresse);
                lvMedecins.Items.Add(item);
                lvMedecins.Size = new Size(400, 200);



            }
        }

        private void lvMedecins_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvMedecins_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
