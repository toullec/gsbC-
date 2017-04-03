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
    public partial class FormCalendrier : Form
    {
        private ListViewItem item;
        public FormCalendrier()
        {
            //initialisation des composants de la fenêtre
            InitializeComponent();

            //parcours de l'arraylist de visite 
            foreach (Visite visite in PasserelleOracle.retournerListVisite())
            {
                //affichage des visites dans un tableau
                item = new ListViewItem();
                item.Text = visite.Reference;
                item.SubItems.Add(visite.Date.ToString());
                item.SubItems.Add(visite.UnVisiteur.Matricule);
                lvVisites.Items.Add(item);
                lvVisites.Size = new Size(400, 200);

            }
        }
    }
}
