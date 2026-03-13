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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            protcent pro = new protcent();
            pro.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            password pass = new password();
            pass.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            temp temp = new temp();
            temp.Show();
        }
    }
}
