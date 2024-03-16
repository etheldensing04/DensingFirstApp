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
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }
        public Result(char op, int num1 = 0, int num2 = 0,String res = null)
        {
            InitializeComponent();
            label1.Text = String.Format($"{num1} {op} {num2} = {res}");
        }

        private void Result_Load(object sender, EventArgs e)
        {

        }
    }
}
