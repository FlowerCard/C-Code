using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15黄子豪sy3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double buildLong = double.Parse(textBox1.Text);
            double buildWidth = double.Parse(textBox2.Text);
            int buildLayers = int.Parse(textBox3.Text);
            double buildPrice = double.Parse(textBox4.Text);

            Building building = new Building();
            building.setBulidVaule(buildLong, buildWidth, buildLayers, buildPrice);
            textBox5.Text = building.getBuildArea().ToString();
            textBox6.Text = building.getBuildPrice().ToString();
        }
    }

    class Building
    {
        /// <summary>
        /// 长：buildLong
        /// 宽：buildWidth
        /// 层数：buildLayers
        /// 单价：buildPrice
        /// 建筑面积：buildArea
        /// 总价：buildTotalPrice
        /// </summary>
        double buildLong;
        double buildWidth;
        int buildLayers;
        double buildPrice;

        /// <summary>
        /// 传参
        /// </summary>
        /// <param name="buildLong"></param>
        /// <param name="buildWidth"></param>
        /// <param name="buildLayers"></param>
        /// <param name="buildPrice"></param>
        /// <param name="buildArea"></param>
        /// <param name="buildTotalPrice"></param>
        public void setBulidVaule(double buildLong, double buildWidth, int buildLayers,double buildPrice)
        {
            this.buildLong = buildLong;
            this.buildWidth = buildWidth;
            this.buildLayers = buildLayers;
            this.buildPrice = buildPrice;
        }

        /// <summary>
        /// 计算建筑面积
        /// </summary>
        /// <returns></returns>
        public double getBuildArea()
        {
            double area = buildLong * buildWidth * buildLayers;
            return area;
        }

        /// <summary>
        /// 计算总价
        /// </summary>
        /// <returns></returns>
        public double getBuildPrice()
        {
            double price = buildLong * buildWidth * buildLayers * buildPrice;
            return price;
        }


    }
}
