namespace AppFenetreMDI
{
    partial class FormNouvVisite
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateVisiteTP = new System.Windows.Forms.DateTimePicker();
            this.referenceTB = new System.Windows.Forms.TextBox();
            this.validerVisiteBtn = new System.Windows.Forms.Button();
            this.visiteurCB = new System.Windows.Forms.ComboBox();
            this.medecinCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.commentaireTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Référence";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Visiteur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Médecin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date visite";
            // 
            // dateVisiteTP
            // 
            this.dateVisiteTP.Location = new System.Drawing.Point(139, 46);
            this.dateVisiteTP.Name = "dateVisiteTP";
            this.dateVisiteTP.Size = new System.Drawing.Size(200, 20);
            this.dateVisiteTP.TabIndex = 4;
            // 
            // referenceTB
            // 
            this.referenceTB.Location = new System.Drawing.Point(139, 24);
            this.referenceTB.Name = "referenceTB";
            this.referenceTB.Size = new System.Drawing.Size(200, 20);
            this.referenceTB.TabIndex = 5;
            // 
            // validerVisiteBtn
            // 
            this.validerVisiteBtn.Location = new System.Drawing.Point(139, 185);
            this.validerVisiteBtn.Name = "validerVisiteBtn";
            this.validerVisiteBtn.Size = new System.Drawing.Size(75, 23);
            this.validerVisiteBtn.TabIndex = 8;
            this.validerVisiteBtn.Text = "Valider visite";
            this.validerVisiteBtn.UseVisualStyleBackColor = true;
            this.validerVisiteBtn.Click += new System.EventHandler(this.validerVisiteBtn_Click);
            // 
            // visiteurCB
            // 
            this.visiteurCB.FormattingEnabled = true;
            this.visiteurCB.Location = new System.Drawing.Point(139, 122);
            this.visiteurCB.Name = "visiteurCB";
            this.visiteurCB.Size = new System.Drawing.Size(200, 21);
            this.visiteurCB.TabIndex = 9;
            // 
            // medecinCB
            // 
            this.medecinCB.FormattingEnabled = true;
            this.medecinCB.Location = new System.Drawing.Point(139, 95);
            this.medecinCB.Name = "medecinCB";
            this.medecinCB.Size = new System.Drawing.Size(200, 21);
            this.medecinCB.TabIndex = 10;
            this.medecinCB.SelectedIndexChanged += new System.EventHandler(this.medecinCB_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Commentaire";
            // 
            // commentaireTB
            // 
            this.commentaireTB.Location = new System.Drawing.Point(139, 72);
            this.commentaireTB.Name = "commentaireTB";
            this.commentaireTB.Size = new System.Drawing.Size(200, 20);
            this.commentaireTB.TabIndex = 12;
            // 
            // FormNouvVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 245);
            this.Controls.Add(this.commentaireTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.medecinCB);
            this.Controls.Add(this.visiteurCB);
            this.Controls.Add(this.validerVisiteBtn);
            this.Controls.Add(this.referenceTB);
            this.Controls.Add(this.dateVisiteTP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormNouvVisite";
            this.Text = "FormNouvVisite";
            this.Load += new System.EventHandler(this.FormNouvVisite_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateVisiteTP;
        private System.Windows.Forms.TextBox referenceTB;
        private System.Windows.Forms.Button validerVisiteBtn;
        private System.Windows.Forms.ComboBox visiteurCB;
        private System.Windows.Forms.ComboBox medecinCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox commentaireTB;
    }
}