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

    public partial class password : Form
    {
        string pass;
        int count = 0;

        public password()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void CheckPasswordLength()
        {
            if (pass.Length < 8)
            {
                textBox2.Text = "Парол короткие напиши пароль с длинну больше чем 8 символов /n ";

            }
        }
        public void ShowPasswordStrength()
        {
            if (pass.Length >= 8 && pass.Length < 12)
            {
                textBox2.Text = "Слабый пароль!";
            }
            else if (pass.Length >= 12 && pass.Length < 16)
            {
                textBox2.Text = "Средний пароль!";
            }
            else if (pass.Length >= 16 && pass.Length <= 19)
            {
                textBox2.Text = "Надежный пароль!";
            }
        }
        public void CheckPasswordDigits()
        {
            if (pass.Length >= 8 && pass.Length <= 19)
            {
                if (pass.Any(char.IsDigit))
                {
                    return;
                }
                else
                {
                    textBox2.Text = "Пароль должен содержать хотя бы одну цифру !";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckPasswordLength();
            ShowPasswordStrength();
            CheckPasswordDigits();
        }
    }
}
