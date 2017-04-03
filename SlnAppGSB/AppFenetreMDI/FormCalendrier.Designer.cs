namespace AppFenetreMDI
{
    partial class FormCalendrier
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.validerBtn = new System.Windows.Forms.Button();
            this.lvVisites = new System.Windows.Forms.ListView();
            this.referenceCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateVisiteCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.visiteurCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medecin";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(113, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // validerBtn
            // 
            this.validerBtn.Location = new System.Drawing.Point(282, 27);
            this.validerBtn.Name = "validerBtn";
            this.validerBtn.Size = new System.Drawing.Size(75, 23);
            this.validerBtn.TabIndex = 2;
            this.validerBtn.Text = "Valider";
            this.validerBtn.UseVisualStyleBackColor = true;
            // 
            // lvVisites
            // 
            this.lvVisites.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.referenceCH,
            this.dateVisiteCH,
            this.visiteurCH});
            this.lvVisites.Location = new System.Drawing.Point(58, 65);
            this.lvVisites.Name = "lvVisites";
            this.lvVisites.Size = new System.Drawing.Size(214, 160);
            this.lvVisites.TabIndex = 3;
            this.lvVisites.UseCompatibleStateImageBehavior = false;
            this.lvVisites.View = System.Windows.Forms.View.Details;
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
            // visiteurCH
            // 
            this.visiteurCH.Text = "Visiteur";
            // 
            // FormCalendrier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 291);
            this.Controls.Add(this.lvVisites);
            this.Controls.Add(this.validerBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormCalendrier";
            this.Text = "FormCalendrier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button validerBtn;
        private System.Windows.Forms.ListView lvVisites;
        private System.Windows.Forms.ColumnHeader referenceCH;
        private System.Windows.Forms.ColumnHeader dateVisiteCH;
        private System.Windows.Forms.ColumnHeader visiteurCH;

    }
}