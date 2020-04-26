using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15黄子豪sy2_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double k = 1;
            double s = 0;


            //int i = 0;
            //while (1 / k >= 1E-4)
            //{
            //    i++;
            //    s = s + 1 / k;
            //    k = k + i;

            //}

            int i = 1;
            while (1 / k >= 1E-4)
            {

                s = s + 1 / k;
                i++;
                k = k + i - 1;

            }

            label3.Text = s.ToString();
            label4.Text = (i-1).ToString();
        }
    }
}
