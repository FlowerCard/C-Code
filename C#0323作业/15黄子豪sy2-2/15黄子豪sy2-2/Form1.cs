using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15黄子豪sy2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //华氏度
        double F = 0;
        //摄氏度
        double C = 0;

        //转换后的温度
        double Tran_F = 0;
        double Tran_C = 0;

        //判断输入的华氏度是否为数字
        private void textBox1_Leave(object sender, EventArgs e)
        {
            try
            {
                F = double.Parse(textBox1.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("请输入正确的华氏度");
                textBox1.Text = "";
                textBox1.Focus();
            }
        }

        //判断输入的摄氏度是否为数字
        private void textBox2_Leave(object sender, EventArgs e)
        {
            try
            {
                C = double.Parse(textBox2.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("请输入正确的摄氏度");
                textBox2.Text = "";
                textBox2.Focus();
            }
        }

        //华氏度转为摄氏度
        private void button1_Click(object sender, EventArgs e)
        {
            F = double.Parse(textBox1.Text);
            Tran_C = (5.0 / 9.0) * (F - 32.0);
            //text2中显示
            textBox2.Text = (Math.Round(Tran_C, 2)).ToString() ;
        }

        //摄氏度转为华氏度
        private void button2_Click(object sender, EventArgs e)
        {
            C = double.Parse(textBox2.Text);
            Tran_F = (9.0 / 5.0) * C + 32.0;
            //在text1中显示
            textBox1.Text = (Math.Round(Tran_F,2)).ToString();
        }
    }
}
