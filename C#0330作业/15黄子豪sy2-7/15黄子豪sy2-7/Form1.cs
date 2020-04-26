using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15黄子豪sy2_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);//获取输入框
            string outNum = null;//定义变量存取输出值
            //for循环
            for (int i = 1; i <= num1; i++)
            {
                //循环找出满足可以被7和13同时整除的数，并存到outNum输出
                if (i % 7 == 0 && i % 13 == 0)
                {
                    outNum = outNum + i.ToString() + " ";
                }
            }

            //while循环
            //int i = 1;
            //while (i < num1)
            //{
            //    if (i % 7 == 0 && i % 13 == 0)
            //    {
            //        outNum = outNum + i.ToString() + " ";
            //    }
            //    i++;
            //}

            //do ... while循环
            //int i = 1;
            //do
            //{
            //    if (i % 7 == 0 && i % 13 == 0)
            //    {
            //        outNum = outNum + i.ToString() + " ";
            //    }
            //    i++;
            //} while (i < num1);

            //将得到的结果存入文本框中
            textBox2.Text = outNum;
        }
    }
}
