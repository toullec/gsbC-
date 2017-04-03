namespace AppFenetreMDI
{
    partial class FormArchivageRetraite
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
            this.lvMedecin = new System.Windows.Forms.ListView();
            this.codeCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prenomCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adresseCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codePostalCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telephoneCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.villeCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.potentielCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.specialiteCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.archivageBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvMedecin
            // 
            this.lvMedecin.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codeCH,
            this.nomCH,
            this.prenomCH,
            this.adresseCH,
            this.codePostalCH,
            this.telephoneCH,
            this.villeCH,
            this.potentielCH,
            this.specialiteCH});
            this.lvMedecin.Location = new System.Drawing.Point(75, 84);
            this.lvMedecin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvMedecin.Name = "lvMedecin";
            this.lvMedecin.Size = new System.Drawing.Size(783, 187);
            this.lvMedecin.TabIndex = 1;
            this.lvMedecin.UseCompatibleStateImageBehavior = false;
            this.lvMedecin.View = System.Windows.Forms.View.Details;
            // 
            // codeCH
            // 
            this.codeCH.Text = "Code";
            this.codeCH.Width = 48;
            // 
            // nomCH
            // 
            this.nomCH.Text = "Nom";
            this.nomCH.Width = 67;
            // 
            // prenomCH
            // 
            this.prenomCH.Text = "Prenom";
            this.prenomCH.Width = 81;
            // 
            // adresseCH
            // 
            this.adresseCH.Text = "Adresse";
            // 
            // codePostalCH
            // 
            this.codePostalCH.Text = "Code postal";
            this.codePostalCH.Width = 75;
            // 
            // telephoneCH
            // 
            this.telephoneCH.Text = "Telephone";
            this.telephoneCH.Width = 65;
            // 
            // villeCH
            // 
            this.villeCH.Text = "Ville";
            // 
            // potentielCH
            // 
            this.potentielCH.Text = "Potentiel";
            // 
            // specialiteCH
            // 
            this.specialiteCH.Text = "Specialite";
            this.specialiteCH.Width = 61;
            // 
            // archivageBtn
            // 
            this.archivageBtn.Location = new System.Drawing.Point(380, 279);
            this.archivageBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.archivageBtn.Name = "archivageBtn";
            this.archivageBtn.Size = new System.Drawing.Size(100, 28);
            this.archivageBtn.TabIndex = 2;
            this.archivageBtn.Text = "Archivage";
            this.archivageBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Archivage de médecins retraités:";
            // 
            // FormArchivageRetraite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 322);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.archivageBtn);
            this.Controls.Add(this.lvMedecin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormArchivageRetraite";
            this.Text = "FormArchivageRetraite";
            this.Load += new System.EventHandler(this.FormArchivageRetraite_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvMedecin;
        private System.Windows.Forms.ColumnHeader codeCH;
        private System.Windows.Forms.ColumnHeader nomCH;
        private System.Windows.Forms.ColumnHeader prenomCH;
        private System.Windows.Forms.ColumnHeader adresseCH;
        private System.Windows.Forms.ColumnHeader codePostalCH;
        private System.Windows.Forms.ColumnHeader telephoneCH;
        private System.Windows.Forms.ColumnHeader villeCH;
        private System.Windows.Forms.ColumnHeader potentielCH;
        private System.Windows.Forms.ColumnHeader specialiteCH;
        private System.Windows.Forms.Button archivageBtn;
        private System.Windows.Forms.Label label1;
    }
}