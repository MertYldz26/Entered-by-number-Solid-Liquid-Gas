using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string hal(int a)
        {
            if (a < 0)
            {
                return "katı";
            }
            else if (a < 100)
            {
                return "sıvı";
            }
            else
            {
                return "gaz";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt16(textBox1.Text);
            label1.Text = hal(a).ToString();


           
        }
    }
}
