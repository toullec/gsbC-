namespace AppFenetreMDI
{
    partial class FormResponsable
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
            this.visiteurCB = new System.Windows.Forms.ComboBox();
            this.responsableCB = new System.Windows.Forms.ComboBox();
            this.affecterBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // visiteurCB
            // 
            this.visiteurCB.FormattingEnabled = true;
            this.visiteurCB.Location = new System.Drawing.Point(30, 60);
            this.visiteurCB.Name = "visiteurCB";
            this.visiteurCB.Size = new System.Drawing.Size(121, 21);
            this.visiteurCB.TabIndex = 0;
            // 
            // responsableCB
            // 
            this.responsableCB.FormattingEnabled = true;
            this.responsableCB.Location = new System.Drawing.Point(30, 119);
            this.responsableCB.Name = "responsableCB";
            this.responsableCB.Size = new System.Drawing.Size(121, 21);
            this.responsableCB.TabIndex = 1;
            // 
            // affecterBtn
            // 
            this.affecterBtn.Location = new System.Drawing.Point(30, 178);
            this.affecterBtn.Name = "affecterBtn";
            this.affecterBtn.Size = new System.Drawing.Size(75, 23);
            this.affecterBtn.TabIndex = 2;
            this.affecterBtn.Text = "Affecter";
            this.affecterBtn.UseVisualStyleBackColor = true;
            this.affecterBtn.Click += new System.EventHandler(this.affecterBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Visiteur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Responsable";
            // 
            // FormResponsable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 315);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.affecterBtn);
            this.Controls.Add(this.responsableCB);
            this.Controls.Add(this.visiteurCB);
            this.Name = "FormResponsable";
            this.Text = "FormResponsable";
            this.Load += new System.EventHandler(this.FormResponsable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox visiteurCB;
        private System.Windows.Forms.ComboBox responsableCB;
        private System.Windows.Forms.Button affecterBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}