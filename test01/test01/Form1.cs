using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y, r;
            x = int.Parse(textBox1.Text);
            y = int.Parse(textBox2.Text);
            r = int.Parse(textBox4.Text);

            double per, area, dis;
            //per=

        }

    }

    class Circle
    {
        public double Perimeter(double r)
        {
            double per;
            per = 2 * Math.PI * r;
            return Math.Round(per);
        }

        public double Area(double r)
        {
            double area;
            area = Math.PI * Math.Pow(r, 2);
            return Math.Round(area);
        }

        public double Distance(double x,double y)
        {
            double dis;
            dis = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return Math.Round(dis);
        }
    }
}
