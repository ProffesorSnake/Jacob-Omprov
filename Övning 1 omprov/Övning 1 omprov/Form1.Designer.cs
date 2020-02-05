namespace Övning_1_omprov
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
            this.btnskrivut = new System.Windows.Forms.Button();
            this.tbxvisa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnskrivut
            // 
            this.btnskrivut.Location = new System.Drawing.Point(253, 217);
            this.btnskrivut.Name = "btnskrivut";
            this.btnskrivut.Size = new System.Drawing.Size(97, 23);
            this.btnskrivut.TabIndex = 0;
            this.btnskrivut.Text = "Skriv ut 1-20";
            this.btnskrivut.UseVisualStyleBackColor = true;
            this.btnskrivut.Click += new System.EventHandler(this.Btnskrivut_Click);
            // 
            // tbxvisa
            // 
            this.tbxvisa.Location = new System.Drawing.Point(253, 270);
            this.tbxvisa.Multiline = true;
            this.tbxvisa.Name = "tbxvisa";
            this.tbxvisa.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxvisa.Size = new System.Drawing.Size(274, 142);
            this.tbxvisa.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxvisa);
            this.Controls.Add(this.btnskrivut);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnskrivut;
        private System.Windows.Forms.TextBox tbxvisa;
    }
}

