using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpmodul3_103022300153
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string namaPraktikan = textBox1.Text;
            if (!string.IsNullOrWhiteSpace(namaPraktikan))
            {
                label1.Text = "Halo " + namaPraktikan;
            }
            else
            {
                label1.Text = "Silakan masukkan nama Anda!";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

    }
}
