using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFenetreMDI
{
    public partial class FormPodium : Form
    {
        private ListViewItem item;
        public FormPodium()
        {
            //initialisation des composants de la fenêtre
            InitializeComponent();

        }

        private void lvVisites_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        PasserelleOracle c = new PasserelleOracle();
        private void afficherBtn_Click(object sender, EventArgs e)
        {
            /*PasserelleOracle.connexionBase();

            //SqlCommand cmd = new SqlCommand("PR_PODIUM", PasserelleOracle.connexionBase());
            OracleCommand cmd = new OracleCommand("PR_PODIUM");
            //cmd.CommandText = "";
            cmd.ExecuteNonQuery();
           // cmd.CommandType = CommandType.StoredProcedure;
            //SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                textBox1.Text = dr[0].ToString();
            }*/
            foreach (Podium unPodium in PasserelleOracle.retournerLePodium())
            {
                //affecte les valeurs des colones et affiche ces valeurs dans un tableau de visiteurs
                item = new ListViewItem();
               // item.Text = u.Matricule;
                item.SubItems.Add(unPodium.Visiteur.Matricule);
                item.SubItems.Add(unPodium.Visiteur.Nom);
                item.SubItems.Add(unPodium.Visiteur.Prenom);
                item.SubItems.Add(""+unPodium.Rang);
                lvPodium.Items.Add(item);
                lvPodium.Size = new Size(400, 200);
            }
        }
    }
}
