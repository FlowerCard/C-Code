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

        //存放字符串
        string Words = null;
        System.Text.ASCIIEncoding aSCII = new System.Text.ASCIIEncoding();

        //加密
        private void button1_Click(object sender, EventArgs e)
        {
            Words = textBox1.Text;
            string outWords = null;
            byte[] array = new byte[Words.Length];
            //
            array = aSCII.GetBytes(Words);
            for (int i = 0; i < array.Length; i++)
            {
                //如果array数组中ASCII为空格，进入下一次循环
                if (array[i] == 32)
                {
                    continue;
                }
                else
                {
                    array[i] += 2;
                }
            }
            outWords = aSCII.GetString(array);
            textBox2.Text = outWords;
        }

        //解密
        private void button2_Click(object sender, EventArgs e)
        {
            Words = textBox2.Text;
            string outWords = null;
            byte[] array = new byte[Words.Length];
            //
            array = aSCII.GetBytes(Words);
            for (int i = 0; i < array.Length; i++)
            {
                //如果array数组中ASCII为空格，进入下一次循环
                if (array[i] == 32)
                {
                    continue;
                }
                else
                {
                    array[i] -= 2;
                }
            }
            outWords = aSCII.GetString(array);
            textBox3.Text = outWords;
        }
    }
}
