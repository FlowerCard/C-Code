using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace _15黄子豪sy2_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string pattern = @"^[0-9]*$";
        private string pattern1 = null;
        private string pattern2 = null;
        private string pattern3 = null;

        //从大到小排序
        private void button1_Click(object sender, EventArgs e)
        {
            //方法一
            //int[] temp = new int[3];
            //temp[0] = int.Parse(pattern1);
            //temp[1] = int.Parse(pattern2);
            //temp[2] = int.Parse(pattern3);
            //for(int i=0; i < temp.Length - 1; i++)
            //{
            //    for(int j=0; j < temp.Length - 1 - i; j++)
            //    {
            //        if (temp[j] > temp[j + 1])
            //        {
            //            int temp2 = 0;
            //            temp2 = temp[j];
            //            temp[j] = temp[j + 1];
            //            temp[j + 1] = temp2;
            //        }
            //    }
            //}

            //label4.Text = temp[2] + ">" + temp[1] + ">" + temp[0];

            //方法二
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);
            int t = 0;
            if (a < c)
            {
                t = c;
                c = a;
                a = t;
            }

            if (a < b)
            {
                t = b;
                b = a;
                a = t;
            }

            if (b < c)
            {
                t = c;
                c = b;
                b = t;
            }

            label4.Text = a.ToString() + ">" + b.ToString() + ">" + c.ToString();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Match m = Regex.Match(textBox1.Text, pattern);
            if (!m.Success)
            {
                textBox1.Text = pattern1;
                textBox1.SelectionStart = textBox1.Text.Length;
            }
            else
            {
                pattern1 = textBox1.Text;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Match m = Regex.Match(textBox2.Text, pattern);
            if (!m.Success)
            {
                textBox2.Text = pattern2;
                textBox2.SelectionStart = textBox2.Text.Length;
            }
            else
            {
                pattern2 = textBox2.Text;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Match m = Regex.Match(textBox3.Text, pattern);
            if (!m.Success)
            {
                textBox3.Text = pattern3;
                textBox3.SelectionStart = textBox3.Text.Length;
            }
            else
            {
                pattern3 = textBox3.Text;
            }
        }
    }
}
