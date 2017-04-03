namespace AppFenetreMDI
{
    partial class FormConsulterVisites
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
            this.lvVisites = new System.Windows.Forms.ListView();
            this.referenceCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateVisiteCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.commentaireCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.medecinCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.visiteurCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.visiteurCB = new System.Windows.Forms.ComboBox();
            this.validerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvVisites
            // 
            this.lvVisites.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.referenceCH,
            this.dateVisiteCH,
            this.commentaireCH,
            this.medecinCH,
            this.visiteurCH});
            this.lvVisites.Location = new System.Drawing.Point(19, 94);
            this.lvVisites.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvVisites.Name = "lvVisites";
            this.lvVisites.Size = new System.Drawing.Size(473, 196);
            this.lvVisites.TabIndex = 0;
            this.lvVisites.UseCompatibleStateImageBehavior = false;
            this.lvVisites.View = System.Windows.Forms.View.Details;
            this.lvVisites.SelectedIndexChanged += new System.EventHandler(this.lvVisites_SelectedIndexChanged);
            // 
            // referenceCH
            // 
            this.referenceCH.Text = "Reference";
            this.referenceCH.Width = 70;
            // 
            // dateVisiteCH
            // 
            this.dateVisiteCH.Text = "Date visite";
            this.dateVisiteCH.Width = 71;
            // 
            // commentaireCH
            // 
            this.commentaireCH.Text = "Commentaire";
            this.commentaireCH.Width = 101;
            // 
            // medecinCH
            // 
            this.medecinCH.Text = "Medecin";
            this.medecinCH.Width = 91;
            // 
            // visiteurCH
            // 
            this.visiteurCH.Text = "Visiteur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste des visites:";
            // 
            // visiteurCB
            // 
            this.visiteurCB.FormattingEnabled = true;
            this.visiteurCB.Location = new System.Drawing.Point(280, 31);
            this.visiteurCB.Name = "visiteurCB";
            this.visiteurCB.Size = new System.Drawing.Size(121, 24);
            this.visiteurCB.TabIndex = 2;
            // 
            // validerBtn
            // 
            this.validerBtn.Location = new System.Drawing.Point(325, 317);
            this.validerBtn.Name = "validerBtn";
            this.validerBtn.Size = new System.Drawing.Size(75, 23);
            this.validerBtn.TabIndex = 3;
            this.validerBtn.Text = "Valider";
            this.validerBtn.UseVisualStyleBackColor = true;
            this.validerBtn.Click += new System.EventHandler(this.validerBtn_Click);
            // 
            // FormConsulterVisites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 373);
            this.Controls.Add(this.validerBtn);
            this.Controls.Add(this.visiteurCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvVisites);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormConsulterVisites";
            this.Text = "FormConsulterVisites";
            this.Load += new System.EventHandler(this.FormConsulterVisites_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvVisites;
        private System.Windows.Forms.ColumnHeader referenceCH;
        private System.Windows.Forms.ColumnHeader dateVisiteCH;
        private System.Windows.Forms.ColumnHeader commentaireCH;
        private System.Windows.Forms.ColumnHeader medecinCH;
        private System.Windows.Forms.ColumnHeader visiteurCH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox visiteurCB;
        private System.Windows.Forms.Button validerBtn;
    }
}