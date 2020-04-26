using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15黄子豪sy2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double price = 0;
        double Dis_price = 0;

        private void textBox1_Leave(object sender, EventArgs e)
        {
            try
            {
                price = double.Parse(textBox1.Text);
            }
            catch (Exception)
            {
                textBox1.Text = "";
                textBox1.Focus();
            }
        }

        //计算折后价格,1k以下原价，1k到2k（含1k）0.9折，2k到3k（含2k）0.8折，3k以上（含3k）0.7折
        private void button1_Click(object sender, EventArgs e)
        {
            price = double.Parse(textBox1.Text);
            if (price < 1000)
            {
                Dis_price = price;
            }else if(price >= 1000 && price < 2000)
            {
                Dis_price = price * 0.9;
            }else if(price >= 2000 && price < 3000)
            {
                Dis_price = price * 0.8;
            }
            else
            {
                Dis_price = price * 0.7;
            }
            label2.Text = Dis_price.ToString();
        }
    }
}
