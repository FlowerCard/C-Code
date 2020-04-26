using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15黄子豪sy2_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //源字符串
            string Source_string = null;
            //查找字符
            string Find_characters = null;
            //替换字符
            string Replace_character = null;
            //结果
            string result = null;

            //将需要替换的字符串赋值给 Source_string
            Source_string = textBox1.Text;
            //将需要被替换的字符赋值给 Find_characters
            Find_characters = textBox2.Text;
            //将用于替换的字符赋值给 Replace_character
            Replace_character = textBox3.Text;

            /**
             * 将需要的被替换的字符（Find_characters）替换为 Replace_character
             * 并在结果（result）中输出
             */
            result = Source_string.Replace(Find_characters, Replace_character);
            label5.Text = result;
        }
    }
}
