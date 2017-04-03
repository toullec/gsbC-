namespace AppFenetreMDI
{
    partial class FormListeMedecins
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
            this.lvMedecins = new System.Windows.Forms.ListView();
            this.codeCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prenomCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adresseCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.specialiteCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvMedecins
            // 
            this.lvMedecins.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codeCH,
            this.nomCH,
            this.prenomCH,
            this.specialiteCH,
            this.adresseCH});
            this.lvMedecins.Location = new System.Drawing.Point(27, 38);
            this.lvMedecins.Name = "lvMedecins";
            this.lvMedecins.Size = new System.Drawing.Size(419, 160);
            this.lvMedecins.TabIndex = 1;
            this.lvMedecins.UseCompatibleStateImageBehavior = false;
            this.lvMedecins.View = System.Windows.Forms.View.Details;
            this.lvMedecins.SelectedIndexChanged += new System.EventHandler(this.lvMedecins_SelectedIndexChanged_1);
            // 
            // codeCH
            // 
            this.codeCH.Text = "Code medecin";
            this.codeCH.Width = 81;
            // 
            // nomCH
            // 
            this.nomCH.Text = "Nom";
            this.nomCH.Width = 71;
            // 
            // prenomCH
            // 
            this.prenomCH.Text = "Prenom";
            this.prenomCH.Width = 81;
            // 
            // adresseCH
            // 
            this.adresseCH.Text = "Adresse";
            this.adresseCH.Width = 123;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Liste dessss médecins:";
            // 
            // specialiteCH
            // 
            this.specialiteCH.Text = "Specialite";
            this.specialiteCH.Width = 123;
            // 
            // FormListeMedecins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 332);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvMedecins);
            this.Name = "FormListeMedecins";
            this.Text = "FormListeMedecins";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvMedecins;
        private System.Windows.Forms.ColumnHeader codeCH;
        private System.Windows.Forms.ColumnHeader nomCH;
        private System.Windows.Forms.ColumnHeader prenomCH;
        private System.Windows.Forms.ColumnHeader adresseCH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader specialiteCH;

    }
}