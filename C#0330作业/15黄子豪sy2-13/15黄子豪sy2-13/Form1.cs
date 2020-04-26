using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15黄子豪sy2_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //定义个输入框初始状态
            textBox1.Text = "";

            //定义长度为10的数组接收产生的随机数
            int[] numArray = new int[10];
            //实例化随机函数
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                //生成-1000到1000之间的随机数
                numArray[i] = (int)(random.Next(-1000, 1000));
            }
            //循环输出随机数
            for (int i = 0; i < numArray.Length; i++)
            {
                textBox1.Text += numArray[i] + "  ";
            }

            //取出最小值、最大值、平均值
            int min = numArray[0];
            int max = numArray[0];
            for (int i = 0; i < numArray.Length; i++)
            {
                if (min > numArray[i])
                {
                    min = numArray[i];
                }

                if (max < numArray[i])
                {
                    max = numArray[i];
                }


            }
            label2.Text = min.ToString();
            label4.Text = max.ToString();
            label6.Text = numArray.Average().ToString();



        }
    }
}
