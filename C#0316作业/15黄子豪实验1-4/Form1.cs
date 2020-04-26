using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15黄子豪实验1_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //lable4存放结果
        float result = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            //加法运算
            result = float.Parse(textBox1.Text) + float.Parse(textBox2.Text);
            label4.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //减法运算
            result = float.Parse(textBox1.Text) - float.Parse(textBox2.Text);
            label4.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //乘法运算
            result = float.Parse(textBox1.Text) * float.Parse(textBox2.Text);
            label4.Text=result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //除法运算
            result = float.Parse(textBox1.Text) / float.Parse(textBox2.Text);
            label4.Text = result.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //清空操作数、结果
            textBox1.Text = "";
            textBox2.Text = "";
            label4.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //退出程序
            Application.Exit();
        }
    }
}
