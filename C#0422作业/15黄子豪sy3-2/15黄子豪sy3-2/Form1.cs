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
            double buidlPrice = double.Parse(textBox4.Text);

            Building building = new Building(buildLong,buildWidth,buildLayers,buidlPrice);

            textBox5.Text = building.getBuildArea().ToString();
            textBox6.Text = building.getBuildPrice().ToString();

        }
    }

    public class Building
    {
        double buildLong;
        double buildWidth;
        int buildLayers;
        double buidlPrice;

        public Building(double buildLong,double buildWidth,int buildLayers,double buidlPrice)
        {
            this.buildLong = buildLong;
            this.buildWidth = buildWidth;
            this.buildLayers = buildLayers;
            this.buidlPrice = buidlPrice;
        }

        public double BuildLong { get => buildLong; set => buildLong = value; }
        public double BuildWidth { get => buildWidth; set => buildWidth = value; }
        public int BuildLayers { get => buildLayers; set => buildLayers = value; }
        public double BuidlPrice { get => buidlPrice; set => buidlPrice = value; }

        public double getBuildArea()
        {
            double area = buildLong * buildWidth * buildLayers;
            return Math.Round(area);
        }

        public double getBuildPrice()
        {
            double price = buildLong * buildWidth * buildLayers * buidlPrice;
            return Math.Round(price);
        }
    }
}
