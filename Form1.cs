using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            double media;
            media = Convert.ToDouble(textBox2.Text);

            if ((media >= 8) && (media <= 10))
            {
                label3.Text = "MB";
            }

            else if ((media >= 6) && (media <= 7))
                     {
                label3.Text = "B";
            }
            else if ((media >= 4) && (media <= 5))
                     {
                label3.Text = "R";
            }
            else if (media <= 4)
                 {
                label3.Text = "I";
            }

        }
    }
}
