namespace uppgift_2_omprov
{
    partial class Form1
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
            this.btnskrivut = new System.Windows.Forms.Button();
            this.tbxbredd = new System.Windows.Forms.TextBox();
            this.tbxhöjd = new System.Windows.Forms.TextBox();
            this.tbxresultat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bredd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Höjd";
            // 
            // btnskrivut
            // 
            this.btnskrivut.Location = new System.Drawing.Point(133, 229);
            this.btnskrivut.Name = "btnskrivut";
            this.btnskrivut.Size = new System.Drawing.Size(75, 23);
            this.btnskrivut.TabIndex = 2;
            this.btnskrivut.Text = "Skriv ut";
            this.btnskrivut.UseVisualStyleBackColor = true;
            this.btnskrivut.Click += new System.EventHandler(this.Btnskrivut_Click);
            // 
            // tbxbredd
            // 
            this.tbxbredd.Location = new System.Drawing.Point(208, 106);
            this.tbxbredd.Name = "tbxbredd";
            this.tbxbredd.Size = new System.Drawing.Size(100, 20);
            this.tbxbredd.TabIndex = 3;
            // 
            // tbxhöjd
            // 
            this.tbxhöjd.Location = new System.Drawing.Point(208, 150);
            this.tbxhöjd.Name = "tbxhöjd";
            this.tbxhöjd.Size = new System.Drawing.Size(100, 20);
            this.tbxhöjd.TabIndex = 4;
            // 
            // tbxresultat
            // 
            this.tbxresultat.Location = new System.Drawing.Point(133, 278);
            this.tbxresultat.Multiline = true;
            this.tbxresultat.Name = "tbxresultat";
            this.tbxresultat.Size = new System.Drawing.Size(307, 141);
            this.tbxresultat.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxresultat);
            this.Controls.Add(this.tbxhöjd);
            this.Controls.Add(this.tbxbredd);
            this.Controls.Add(this.btnskrivut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnskrivut;
        private System.Windows.Forms.TextBox tbxbredd;
        private System.Windows.Forms.TextBox tbxhöjd;
        private System.Windows.Forms.TextBox tbxresultat;
    }
}

