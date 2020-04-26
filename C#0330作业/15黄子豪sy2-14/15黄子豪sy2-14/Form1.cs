using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15黄子豪sy2_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] numArray = new int[10];

        private void button1_Click(object sender, EventArgs e)
        {
            //初始化输入框
            textBox1.Text = "";

            //生成10个1到100之间的随机数
            Random random1 = new Random();
            for(int i = 0; i < 10; i++)
            {
                numArray[i] = (int)(random1.Next(1, 100));
            }

            for(int i = 0; i < numArray.Length; i++)
            {
                textBox1.Text += numArray[i] + " ";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //初始化文本框
            label1.Text = "";

            //从小到大排序
            for(int i = 0; i < numArray.Length - 1; i++)
            {
                for (int j = 0; j < numArray.Length - i - 1; j++)
                {
                    if (numArray[j] > numArray[j + 1])
                    {
                        int temp = numArray[j];
                        numArray[j] = numArray[j + 1];
                        numArray[j + 1] = temp;
                    }
                }
            }

            for(int i = 0; i < numArray.Length; i++)
            {
                label1.Text += numArray[i].ToString() + " ";
            }
        }
    }
}
