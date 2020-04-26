using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15黄子豪实验1_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //定时器停止
            timer1.Enabled = false;
            //调用textMove()方法
            textMove();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //定时器开启
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender,EventArgs e)
        {
            //调用textMove()方法
            textMove();
        }

        private void textMove()
        {
            label1.Top = label1.Top - 5;
            if (label1.Top < label1.Height)
            {
                label1.Top = this.Height - label1.Height;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
