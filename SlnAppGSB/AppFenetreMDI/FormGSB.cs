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
    public partial class FormGSB : Form
    {
        public FormGSB()
        {
            InitializeComponent();
        }

        private void nouvelleVisiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //lancement de la fenêtre nouvelle visite lors du click sur nouvelle visite
            FormNouvVisite newMDIChild = new FormNouvVisite();

            newMDIChild.MdiParent = this;

            newMDIChild.Dock = DockStyle.Fill;
            newMDIChild.Show();
        }

        private void listeVisiteursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //lancement de la fenêtre liste visiteur lors du click sur le bouton liste visiteur
            FormListeVisiteurs newMDIChild = new FormListeVisiteurs();

            newMDIChild.MdiParent = this;

            newMDIChild.Dock = DockStyle.Fill;
            newMDIChild.Show();
        }

        private void FormGSB_Load(object sender, EventArgs e)
        {

        }

        private void listeDesMédecinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //lancement de la fenêtre liste des médecins lors du click liste medecin
            FormListeMedecins newMDIChild = new FormListeMedecins();

            newMDIChild.MdiParent = this;

            newMDIChild.Dock = DockStyle.Fill;
            newMDIChild.Show();
        }

        private void podiumVisiteursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //lancement de la fenêtre podium visiteur lors du click podium visiteur
            FormPodium newMDIChild = new FormPodium();

            newMDIChild.MdiParent = this;

            newMDIChild.Dock = DockStyle.Fill;
            newMDIChild.Show();
        }

        private void consulterVisitesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //lancement de la fenêtre consulter visites lors du click consulter visites
            FormConsulterVisites newMDIChild = new FormConsulterVisites();

            newMDIChild.MdiParent = this;

            newMDIChild.Dock = DockStyle.Fill;
            newMDIChild.Show();
        }

        private void visitesÀPrévoirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //lancement de la fenêtre visites à prevoir lors du click visites à prévoir
            FormVisitesPrevoir newMDIChild = new FormVisitesPrevoir();

            newMDIChild.MdiParent = this;

            newMDIChild.Dock = DockStyle.Fill;
            newMDIChild.Show();
        }

        private void calendrierPrévisionnelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //lancement de la fenêtre calendrier prévisonnel lors du click calendrier prévisionnel
            FormCalendrier newMDIChild = new FormCalendrier();

            newMDIChild.MdiParent = this;

            newMDIChild.Dock = DockStyle.Fill;
            newMDIChild.Show();
        }

        private void archivageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ////lancement de la fenêtre archivage lors du click archivage
            FormArchivageRetraite newMDIChild = new FormArchivageRetraite();

            newMDIChild.MdiParent = this;

            newMDIChild.Dock = DockStyle.Fill;
            newMDIChild.Show();
        }

        private void affecterResponsableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //lancement de la fenêtre affecter responsable lors du click affecter responsable
            FormResponsable newMDIChild = new FormResponsable();

            newMDIChild.MdiParent = this;

            newMDIChild.Dock = DockStyle.Fill;
            newMDIChild.Show();
        }
    }
}
