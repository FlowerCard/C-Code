using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15黄子豪sy2_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(textBox1.Text);
            float num2 = float.Parse(textBox3.Text);
            float result = 0;

            if (num2 == 0 && textBox2.Text=="/" )
            {
                MessageBox.Show("除数不能为0", "提示");
                textBox3.SelectionStart = textBox3.Text.Length;
                textBox3.Focus();
            }

            switch (textBox2.Text)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
            }
            label6.Text = result.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            switch (textBox2.Text)
            {
                case "+":
                    break;
                case "-":
                    break;
                case "*":
                    break;
                case "/":
                    break;
                default:
                    textBox2.Text = "";
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
