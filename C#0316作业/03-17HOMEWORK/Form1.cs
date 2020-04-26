using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_17HOMEWORK
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //左移
            int step = int.Parse(textBox1.Text);
            label1.Left = label1.Left - step;
            if (label1.Left < -label1.Width)
            {
                label1.Left = this.Width;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //右移
            int step = int.Parse(textBox1.Text);
            label1.Left = label1.Left + step;
            if (label1.Left > this.Width)
            {
                label1.Left = -label1.Width;
            }
        }
    }
}
