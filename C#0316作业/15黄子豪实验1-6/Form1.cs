using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15黄子豪实验1_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //设置窗体文本
            this.Text = "文本复制";
            //设置textBox1的文字
            this.textBox1.Text = "欢迎学习C# .NET，需要认真学习";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //启动fontDialog

            //字体对华空中出现字体颜色选项，此项一定要在ShowDialog()之前才有效
            fontDialog1.ShowColor = true;
            //弹出字体设置对话框
            fontDialog1.ShowDialog();
            //将字体对话框的字体属性赋值给文本框
            textBox1.Font = fontDialog1.Font;
            //fontDialog.Font不包括字体的颜色,需要额外设置
            textBox1.ForeColor = fontDialog1.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font("宋体", 9.0f);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //复制
            if(textBox1.SelectedText != "")
            {
                Clipboard.SetDataObject(textBox1.SelectedText);
            }

            //粘贴
            IDataObject iData = Clipboard.GetDataObject();
            if (iData.GetDataPresent(DataFormats.Text))
            {
                textBox2.Font = textBox1.Font;
                textBox2.Text = (String)iData.GetData(DataFormats.Text);
            }
        }
    }
}
