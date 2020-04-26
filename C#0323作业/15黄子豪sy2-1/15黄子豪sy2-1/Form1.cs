using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15黄子豪sy2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double r = 0;

        //计算圆面积
        private void button1_Click(object sender, EventArgs e)
        {
            double area = 0;
            r = double.Parse(textBox1.Text);
            area = Math.PI * (r * r);
            label2.Text = area.ToString();
        }

        //输入圆的半径
        private void textBox1_Leave(object sender, EventArgs e)
        {
            try
            {
                r = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("请输入数字");
                textBox1.Text = "";
                textBox1.Focus();
            }
        }

        //计算圆周长
        private void button2_Click(object sender, EventArgs e)
        {
            double perimeter = 0;
            r = double.Parse(textBox1.Text);
            perimeter = 2 * Math.PI * r;
            label3.Text = perimeter.ToString();
        }
    }
}
