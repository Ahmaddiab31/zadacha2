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
    public partial class protcent : Form
    {
        int price = 0;
        int pro = 0;
        public protcent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            price = int.Parse(textBox1.Text);
            if(price <= 1000)
            {
                textBox2.Text = price.ToString();
            }
            if(1000 < price && price <= 5000)
            {
                pro = (price / 100) * 5;
                price = price - pro;
                textBox2.Text = price.ToString();
            }
            if(price > 5000)
            {
                pro = (price / 100) * 10;
                price = price - pro;
                textBox2.Text = price.ToString();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
