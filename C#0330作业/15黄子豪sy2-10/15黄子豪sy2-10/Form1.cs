using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15黄子豪sy2_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = 0;
            string outReslut = null;
            for(int i = 1; i <= 9; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    result = i * j;
                    outReslut += i.ToString() + " * " + j.ToString() + " = " + result.ToString() + "  ";
                }
                outReslut += "\r\n" + "\r\n";
            }
            label1.Text = outReslut ;
        }
    }
}
