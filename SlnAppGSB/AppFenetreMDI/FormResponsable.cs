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
    public partial class FormResponsable : Form
    {
        private ListViewItem item;
        public FormResponsable()
        {
            //initialisation des composants de la fenêtre
            InitializeComponent();
        
            //parcours de l'arraylist de visiteur
            foreach (Visiteur visiteur in PasserelleOracle.retournerListVisiteur())
            {
                //ajout des matricule dans le combobox de visiteur
                item = new ListViewItem();
                
                visiteurCB.Items.Add(visiteur.Matricule);
               

            }

            //parcours des responsables avec l'arraylist de responsables
            foreach (Responsable responsable in PasserelleOracle.retournerListResponsable())
            {

                //ajout du matricule des responsables dans le combobox
                item = new ListViewItem();

                responsableCB.Items.Add(responsable.Matricule);


            }
        }

        private void FormResponsable_Load(object sender, EventArgs e)
        {

        }

        private void affecterBtn_Click(object sender, EventArgs e)
        {
            //affectation d'un responsable avec le code visiteur et le code du responsable des combobox
            PasserelleOracle.affecterResponsable(visiteurCB.Text, responsableCB.Text);


        }
    }
}
