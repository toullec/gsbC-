namespace AppFenetreMDI
{
    partial class FormGSB
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.visitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelleVisiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterVisitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitesÀPrévoirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendrierPrévisionnelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.podiumVisiteursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visiteursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeVisiteursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affecterResponsableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médecinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesMédecinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visitesToolStripMenuItem,
            this.statistiquesToolStripMenuItem,
            this.visiteursToolStripMenuItem,
            this.médecinsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(647, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // visitesToolStripMenuItem
            // 
            this.visitesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouvelleVisiteToolStripMenuItem,
            this.consulterVisitesToolStripMenuItem,
            this.visitesÀPrévoirToolStripMenuItem,
            this.calendrierPrévisionnelToolStripMenuItem});
            this.visitesToolStripMenuItem.Name = "visitesToolStripMenuItem";
            this.visitesToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.visitesToolStripMenuItem.Text = "Visites";
            // 
            // nouvelleVisiteToolStripMenuItem
            // 
            this.nouvelleVisiteToolStripMenuItem.Name = "nouvelleVisiteToolStripMenuItem";
            this.nouvelleVisiteToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.nouvelleVisiteToolStripMenuItem.Text = "Nouvelle Visite";
            this.nouvelleVisiteToolStripMenuItem.Click += new System.EventHandler(this.nouvelleVisiteToolStripMenuItem_Click);
            // 
            // consulterVisitesToolStripMenuItem
            // 
            this.consulterVisitesToolStripMenuItem.Name = "consulterVisitesToolStripMenuItem";
            this.consulterVisitesToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.consulterVisitesToolStripMenuItem.Text = "Consulter visites";
            this.consulterVisitesToolStripMenuItem.Click += new System.EventHandler(this.consulterVisitesToolStripMenuItem_Click);
            // 
            // visitesÀPrévoirToolStripMenuItem
            // 
            this.visitesÀPrévoirToolStripMenuItem.Name = "visitesÀPrévoirToolStripMenuItem";
            this.visitesÀPrévoirToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.visitesÀPrévoirToolStripMenuItem.Text = "Visites à prévoir";
            this.visitesÀPrévoirToolStripMenuItem.Click += new System.EventHandler(this.visitesÀPrévoirToolStripMenuItem_Click);
            // 
            // calendrierPrévisionnelToolStripMenuItem
            // 
            this.calendrierPrévisionnelToolStripMenuItem.Name = "calendrierPrévisionnelToolStripMenuItem";
            this.calendrierPrévisionnelToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.calendrierPrévisionnelToolStripMenuItem.Text = "Calendrier prévisionnel";
            this.calendrierPrévisionnelToolStripMenuItem.Click += new System.EventHandler(this.calendrierPrévisionnelToolStripMenuItem_Click);
            // 
            // statistiquesToolStripMenuItem
            // 
            this.statistiquesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.podiumVisiteursToolStripMenuItem});
            this.statistiquesToolStripMenuItem.Name = "statistiquesToolStripMenuItem";
            this.statistiquesToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.statistiquesToolStripMenuItem.Text = "Statistiques";
            // 
            // podiumVisiteursToolStripMenuItem
            // 
            this.podiumVisiteursToolStripMenuItem.Name = "podiumVisiteursToolStripMenuItem";
            this.podiumVisiteursToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.podiumVisiteursToolStripMenuItem.Text = "Podium visiteurs";
            this.podiumVisiteursToolStripMenuItem.Click += new System.EventHandler(this.podiumVisiteursToolStripMenuItem_Click);
            // 
            // visiteursToolStripMenuItem
            // 
            this.visiteursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeVisiteursToolStripMenuItem,
            this.affecterResponsableToolStripMenuItem});
            this.visiteursToolStripMenuItem.Name = "visiteursToolStripMenuItem";
            this.visiteursToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.visiteursToolStripMenuItem.Text = "Visiteurs";
            // 
            // listeVisiteursToolStripMenuItem
            // 
            this.listeVisiteursToolStripMenuItem.Name = "listeVisiteursToolStripMenuItem";
            this.listeVisiteursToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.listeVisiteursToolStripMenuItem.Text = "Liste visiteurs";
            this.listeVisiteursToolStripMenuItem.Click += new System.EventHandler(this.listeVisiteursToolStripMenuItem_Click);
            // 
            // affecterResponsableToolStripMenuItem
            // 
            this.affecterResponsableToolStripMenuItem.Name = "affecterResponsableToolStripMenuItem";
            this.affecterResponsableToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.affecterResponsableToolStripMenuItem.Text = "Affecter responsable";
            this.affecterResponsableToolStripMenuItem.Click += new System.EventHandler(this.affecterResponsableToolStripMenuItem_Click);
            // 
            // médecinsToolStripMenuItem
            // 
            this.médecinsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesMédecinsToolStripMenuItem,
            this.archivageToolStripMenuItem});
            this.médecinsToolStripMenuItem.Name = "médecinsToolStripMenuItem";
            this.médecinsToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.médecinsToolStripMenuItem.Text = "Médecins";
            // 
            // listeDesMédecinsToolStripMenuItem
            // 
            this.listeDesMédecinsToolStripMenuItem.Name = "listeDesMédecinsToolStripMenuItem";
            this.listeDesMédecinsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.listeDesMédecinsToolStripMenuItem.Text = "Liste des médecins";
            this.listeDesMédecinsToolStripMenuItem.Click += new System.EventHandler(this.listeDesMédecinsToolStripMenuItem_Click);
            // 
            // archivageToolStripMenuItem
            // 
            this.archivageToolStripMenuItem.Name = "archivageToolStripMenuItem";
            this.archivageToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.archivageToolStripMenuItem.Text = "Archivage";
            this.archivageToolStripMenuItem.Click += new System.EventHandler(this.archivageToolStripMenuItem_Click);
            // 
            // FormGSB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 345);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormGSB";
            this.Text = "FormGSB";
            this.Load += new System.EventHandler(this.FormGSB_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem visitesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouvelleVisiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterVisitesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitesÀPrévoirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendrierPrévisionnelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistiquesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem podiumVisiteursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visiteursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeVisiteursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médecinsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesMédecinsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affecterResponsableToolStripMenuItem;
    }
}

