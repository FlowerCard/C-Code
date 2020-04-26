using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double b = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = 0;
                a = double.Parse(textBox1.Text);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            try {
                b = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("请输入数字");
                textBox1.Text = "";
                textBox1.Focus();
            }
        }
    }
}
