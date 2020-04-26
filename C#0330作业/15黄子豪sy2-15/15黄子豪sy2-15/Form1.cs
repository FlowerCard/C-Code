using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15黄子豪sy2_15
{
    public partial class Form1 : Form
    {

        int a = 0;
        int b = 0;
        int result = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                a = int.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("将 a 的值输入为数字", "除数异常");
                textBox1.Focus();
                textBox1.Text = "";
                return;
            }

            try
            {
                b = int.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("将 b 的值输入为数字", "被除数异常");
                textBox2.Focus();
                textBox2.Text = "";
                return;
            }

            try
            {
                result = a / b;
            }
            catch
            {
                MessageBox.Show("被除数不能为零", "被除数异常");
                textBox2.Focus();
                textBox2.Text = "";
                return;
            }

            //if ()
            //{
            //    throw new DivideByZeroException
            //}
            MessageBox.Show("整数a与整数b的商为：" + result.ToString(),"结果输出");
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
          
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
           
        }
    }
}
