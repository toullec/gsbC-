namespace AppFenetreMDI
{
    partial class FormPodium
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
            this.lvPodium = new System.Windows.Forms.ListView();
            this.nomCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrenomCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.matriculeCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nombreVisiteCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateDebutDTP = new System.Windows.Forms.DateTimePicker();
            this.dateFinDTP = new System.Windows.Forms.DateTimePicker();
            this.afficherBtn = new System.Windows.Forms.Button();
            this.dateDebutLab = new System.Windows.Forms.Label();
            this.dateFinLab = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lvPodium
            // 
            this.lvPodium.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nomCH,
            this.PrenomCH,
            this.matriculeCH,
            this.nombreVisiteCH});
            this.lvPodium.Location = new System.Drawing.Point(63, 91);
            this.lvPodium.Margin = new System.Windows.Forms.Padding(4);
            this.lvPodium.Name = "lvPodium";
            this.lvPodium.Size = new System.Drawing.Size(473, 197);
            this.lvPodium.TabIndex = 1;
            this.lvPodium.UseCompatibleStateImageBehavior = false;
            this.lvPodium.View = System.Windows.Forms.View.Details;
            this.lvPodium.SelectedIndexChanged += new System.EventHandler(this.lvVisites_SelectedIndexChanged);
            // 
            // nomCH
            // 
            this.nomCH.Text = "Nom";
            this.nomCH.Width = 70;
            // 
            // PrenomCH
            // 
            this.PrenomCH.Text = "Prenom";
            this.PrenomCH.Width = 71;
            // 
            // matriculeCH
            // 
            this.matriculeCH.Text = "Matricule";
            // 
            // nombreVisiteCH
            // 
            this.nombreVisiteCH.Text = "Nombre de visite";
            this.nombreVisiteCH.Width = 127;
            // 
            // dateDebutDTP
            // 
            this.dateDebutDTP.Location = new System.Drawing.Point(116, 16);
            this.dateDebutDTP.Margin = new System.Windows.Forms.Padding(4);
            this.dateDebutDTP.Name = "dateDebutDTP";
            this.dateDebutDTP.Size = new System.Drawing.Size(265, 22);
            this.dateDebutDTP.TabIndex = 2;
            // 
            // dateFinDTP
            // 
            this.dateFinDTP.Location = new System.Drawing.Point(520, 14);
            this.dateFinDTP.Margin = new System.Windows.Forms.Padding(4);
            this.dateFinDTP.Name = "dateFinDTP";
            this.dateFinDTP.Size = new System.Drawing.Size(265, 22);
            this.dateFinDTP.TabIndex = 3;
            // 
            // afficherBtn
            // 
            this.afficherBtn.Location = new System.Drawing.Point(63, 48);
            this.afficherBtn.Margin = new System.Windows.Forms.Padding(4);
            this.afficherBtn.Name = "afficherBtn";
            this.afficherBtn.Size = new System.Drawing.Size(100, 28);
            this.afficherBtn.TabIndex = 4;
            this.afficherBtn.Text = "Afficher";
            this.afficherBtn.UseVisualStyleBackColor = true;
            this.afficherBtn.Click += new System.EventHandler(this.afficherBtn_Click);
            // 
            // dateDebutLab
            // 
            this.dateDebutLab.AutoSize = true;
            this.dateDebutLab.Location = new System.Drawing.Point(8, 22);
            this.dateDebutLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateDebutLab.Name = "dateDebutLab";
            this.dateDebutLab.Size = new System.Drawing.Size(98, 17);
            this.dateDebutLab.TabIndex = 5;
            this.dateDebutLab.Text = "Date de début";
            // 
            // dateFinLab
            // 
            this.dateFinLab.AutoSize = true;
            this.dateFinLab.Location = new System.Drawing.Point(433, 16);
            this.dateFinLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateFinLab.Name = "dateFinLab";
            this.dateFinLab.Size = new System.Drawing.Size(77, 17);
            this.dateFinLab.TabIndex = 6;
            this.dateFinLab.Text = "Date de fin";
            this.dateFinLab.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(691, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 7;
            // 
            // FormPodium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 362);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateFinLab);
            this.Controls.Add(this.dateDebutLab);
            this.Controls.Add(this.afficherBtn);
            this.Controls.Add(this.dateFinDTP);
            this.Controls.Add(this.dateDebutDTP);
            this.Controls.Add(this.lvPodium);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPodium";
            this.Text = "FormPodium";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvPodium;
        private System.Windows.Forms.ColumnHeader nomCH;
        private System.Windows.Forms.ColumnHeader PrenomCH;
        private System.Windows.Forms.ColumnHeader matriculeCH;
        private System.Windows.Forms.ColumnHeader nombreVisiteCH;
        private System.Windows.Forms.DateTimePicker dateDebutDTP;
        private System.Windows.Forms.DateTimePicker dateFinDTP;
        private System.Windows.Forms.Button afficherBtn;
        private System.Windows.Forms.Label dateDebutLab;
        private System.Windows.Forms.Label dateFinLab;
        private System.Windows.Forms.TextBox textBox1;
    }
}