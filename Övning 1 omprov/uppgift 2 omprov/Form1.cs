using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppgift_2_omprov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnskrivut_Click(object sender, EventArgs e)
        {
            int i= 1;

            while( i <= int.Parse(tbxbredd.Text))
            {
                i++;
                tbxresultat.Text += i;

            }

            while( i <= int.Parse(tbxhöjd.Text))
            {
                i++;
                tbxresultat.Text = "\r\n";
            }


            
        }
    }
}
