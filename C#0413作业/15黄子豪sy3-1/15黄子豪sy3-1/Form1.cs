using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15黄子豪sy3_1
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
            Circle circle = new Circle();
            x = double.Parse(textBox1.Text);
            y = double.Parse(textBox2.Text);
            r = double.Parse(textBox4.Text);
            //circle.SetValue(x, y, r);
            circle.X = x;
            circle.Y = y;
            circle.R = r;



            double per, area, dis;
            per = circle.Perimeter();
            area = circle.Area();
            dis = circle.Distance();

            label5.Text = area.ToString();
            label7.Text = per.ToString();
            label9.Text = dis.ToString();

            
        }
    }

    /// <summary>
    /// 圆面积、周长、原点距离计算
    /// </summary>
    class Circle
    {
        private double x;
        private double y;
        private double r;

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public double R { get => r; set => r = value; }

        /// <summary>
        /// (x,y)原点坐标，r半径
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="r"></param>
        //public void SetValue(double x,double y,double r)
        //{
        //    this.x = x;
        //    this.y = y;
        //    this.r = r;
        //}

        /// <summary>
        /// 计算周长：2πr
        /// </summary>
        /// <returns></returns>

        public double Perimeter()
        {
            return Math.Round(2 * Math.PI * r,2);
        }
        /// <summary>
        /// 计算面积：πr^2
        /// </summary>
        /// <returns></returns>

        public double Area()
        {
            return Math.Round(Math.PI * Math.Pow(r, 2),2);
        }
        /// <summary>
        /// 计算距离：Sqrt(x^2+y^2)
        /// </summary>
        /// <returns></returns>

        public double Distance()
        {
            return Math.Round(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)),2);
        }
       
    }
}
