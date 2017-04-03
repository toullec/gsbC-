namespace AppFenetreMDI
{
    partial class FormListeVisiteurs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chMatricule = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPrenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAdresse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvVisiteurs = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // chMatricule
            // 
            this.chMatricule.Text = "Matricule";
            // 
            // chNom
            // 
            this.chNom.Text = "Nom";
            // 
            // chPrenom
            // 
            this.chPrenom.Text = "Prenom";
            // 
            // chAdresse
            // 
            this.chAdresse.Text = "Adresse";
            // 
            // chCP
            // 
            this.chCP.Text = "Code postal";
            this.chCP.Width = 105;
            // 
            // lvVisiteurs
            // 
            this.lvVisiteurs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chMatricule,
            this.chNom,
            this.chPrenom,
            this.chAdresse,
            this.chCP});
            this.lvVisiteurs.GridLines = true;
            this.lvVisiteurs.Location = new System.Drawing.Point(29, 34);
            this.lvVisiteurs.Name = "lvVisiteurs";
            this.lvVisiteurs.Size = new System.Drawing.Size(351, 132);
            this.lvVisiteurs.TabIndex = 0;
            this.lvVisiteurs.UseCompatibleStateImageBehavior = false;
            this.lvVisiteurs.View = System.Windows.Forms.View.Details;
            this.lvVisiteurs.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // FormListeVisiteurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 276);
            this.Controls.Add(this.lvVisiteurs);
            this.Name = "FormListeVisiteurs";
            this.Text = "FormListeVisiteurs";
            this.Load += new System.EventHandler(this.FormListeVisiteurs_Load);
            this.ResumeLayout(false);



        }

        #endregion

        private System.Windows.Forms.ColumnHeader chMatricule;
        private System.Windows.Forms.ColumnHeader chNom;
        private System.Windows.Forms.ColumnHeader chPrenom;
        private System.Windows.Forms.ColumnHeader chAdresse;
        private System.Windows.Forms.ColumnHeader chCP;
        private System.Windows.Forms.ListView lvVisiteurs;


    }
}