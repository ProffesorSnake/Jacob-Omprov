namespace uppgift_3_omprov
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
            this.btnsök = new System.Windows.Forms.Button();
            this.tbxtext = new System.Windows.Forms.TextBox();
            this.tbxbokstav = new System.Windows.Forms.TextBox();
            this.lblresultat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsök
            // 
            this.btnsök.Location = new System.Drawing.Point(214, 282);
            this.btnsök.Name = "btnsök";
            this.btnsök.Size = new System.Drawing.Size(75, 23);
            this.btnsök.TabIndex = 0;
            this.btnsök.Text = "Sök";
            this.btnsök.UseVisualStyleBackColor = true;
            this.btnsök.Click += new System.EventHandler(this.Btnsök_Click);
            // 
            // tbxtext
            // 
            this.tbxtext.Location = new System.Drawing.Point(214, 107);
            this.tbxtext.Multiline = true;
            this.tbxtext.Name = "tbxtext";
            this.tbxtext.Size = new System.Drawing.Size(195, 139);
            this.tbxtext.TabIndex = 1;
            // 
            // tbxbokstav
            // 
            this.tbxbokstav.Location = new System.Drawing.Point(320, 284);
            this.tbxbokstav.Name = "tbxbokstav";
            this.tbxbokstav.Size = new System.Drawing.Size(55, 20);
            this.tbxbokstav.TabIndex = 2;
            // 
            // lblresultat
            // 
            this.lblresultat.AutoSize = true;
            this.lblresultat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblresultat.Location = new System.Drawing.Point(214, 336);
            this.lblresultat.Name = "lblresultat";
            this.lblresultat.Size = new System.Drawing.Size(2, 15);
            this.lblresultat.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblresultat);
            this.Controls.Add(this.tbxbokstav);
            this.Controls.Add(this.tbxtext);
            this.Controls.Add(this.btnsök);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsök;
        private System.Windows.Forms.TextBox tbxtext;
        private System.Windows.Forms.TextBox tbxbokstav;
        private System.Windows.Forms.Label lblresultat;
    }
}

