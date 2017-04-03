namespace AppFenetreMDI
{
    partial class FormVisitesPrevoir
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
            this.lvVisites.Location = new System.Drawing.Point(52, 57);
            this.lvVisites.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvVisites.Name = "lvVisites";
            this.lvVisites.Size = new System.Drawing.Size(589, 259);
            this.lvVisites.TabIndex = 1;
            this.lvVisites.UseCompatibleStateImageBehavior = false;
            this.lvVisites.View = System.Windows.Forms.View.Details;
            // 
            // referenceCH
            // 
            this.referenceCH.Text = "Reference";
            this.referenceCH.Width = 89;
            // 
            // dateVisiteCH
            // 
            this.dateVisiteCH.Text = "Date visite";
            this.dateVisiteCH.Width = 126;
            // 
            // commentaireCH
            // 
            this.commentaireCH.Text = "Commentaire";
            this.commentaireCH.Width = 147;
            // 
            // medecinCH
            // 
            this.medecinCH.Text = "Medecin";
            this.medecinCH.Width = 116;
            // 
            // visiteurCH
            // 
            this.visiteurCH.Text = "Visiteur";
            this.visiteurCH.Width = 177;
            // 
            // FormVisitesPrevoir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 417);
            this.Controls.Add(this.lvVisites);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormVisitesPrevoir";
            this.Text = "FormVisitesPrevoir";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvVisites;
        private System.Windows.Forms.ColumnHeader referenceCH;
        private System.Windows.Forms.ColumnHeader dateVisiteCH;
        private System.Windows.Forms.ColumnHeader commentaireCH;
        private System.Windows.Forms.ColumnHeader medecinCH;
        private System.Windows.Forms.ColumnHeader visiteurCH;
    }
}