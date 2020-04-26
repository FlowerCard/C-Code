using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15黄子豪实验1_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("Azul.jpg");
            //图片拉伸布局
            BackgroundImageLayout = ImageLayout.Stretch;
            this.Text = "载入窗体";
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("Red moon desert.jpg");
            BackgroundImageLayout = ImageLayout.Stretch;
            this.Text = "单击窗体";
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("Moon flower.jpg");
            BackgroundImageLayout = ImageLayout.Stretch;
            this.Text = "双击窗体";
        }
    }
}
