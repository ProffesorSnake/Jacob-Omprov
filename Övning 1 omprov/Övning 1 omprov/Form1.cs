using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_1_omprov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnskrivut_Click(object sender, EventArgs e)
        {
            tbxvisa.Text = "";

            for (int i = 0; i < 10; i++)
            {
                tbxvisa.Text += i + " ";
            }



            int x = 9;

            while(x < 19)
            {
                x++;
                tbxvisa.Text += x + " ";
            }
        }
    }
}
