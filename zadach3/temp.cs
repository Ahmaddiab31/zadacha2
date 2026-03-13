using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadach3
{
    public partial class temp : Form
    {
        double C = 0;
        double F = 0;
        public temp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            temparC();
        }
        public void temparC()
        {
            C = double.Parse(textBox1.Text);
            C = (C * 1.8) + 32;
            textBox2.Text = C.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            F =double.Parse(textBox4.Text);
            F = (F - 32) / 1.8;
            textBox3.Text = F.ToString();
        }
    }
}
