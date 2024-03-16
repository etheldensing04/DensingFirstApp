using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DensingFirstApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private  string getRes(char op, int num1, int num2)
        {


            int res = 0;

            if (op == '+')
            {
                res = num1 + num2;
            }else if (op == '-')
            {
                res = num1 - num2;
            }else if (op == '*')
            {
                res = num1 * num2;
            }else if (op == '/')
            {
                res = num1 / num2;
            }

            return res.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text.Trim());
            int num2 = Convert.ToInt32(textBox2.Text.Trim());

            Result res = new Result('+', num1, num2, getRes('+', num1, num2));
            res.ShowDialog();
        }

        private void buttonsub_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text.Trim());
            int num2 = Convert.ToInt32(textBox2.Text.Trim());
            Result res = new Result('-', num1, num2, getRes('-', num1, num2));
            res.ShowDialog();
        }

        private void buttonmultip_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text.Trim());
            int num2 = Convert.ToInt32(textBox2.Text.Trim());
            Result res = new Result('*', num1, num2, getRes('*', num1, num2));
            res.ShowDialog();
        }

        private void buttondivide_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text.Trim());
            int num2 = Convert.ToInt32(textBox2.Text.Trim());
            Result res = new Result('/', num1, num2, getRes('/', num1, num2));
            res.ShowDialog();
        }
    }
}
