using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppgift_3_omprov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnsök_Click(object sender, EventArgs e)
        {
            string[] bokstav = new string[tbxtext.Text.Length];

            int antal = 0;

            for (int i = 0; i < tbxtext.TextLength; i++)
            {
                

                if (bokstav[i] == tbxbokstav.Text)
                {
                    antal++;
                    
                }
            }


            lblresultat.Text = "Vi hittade " + antal + " " + tbxbokstav.Text;
        }
    }
}
