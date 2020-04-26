using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<double> G_list_value = new List<double>();
        private bool G_bl_add = false;
        private bool G_bl_value = false;
        private bool G_bl_key = false;
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (G_bl_value)
            {
                G_bl_value = false;
                G_bl_key = true;
            }
            else
            {
                if (!G_bl_key)
                {
                    G_list_value.Add(double.Parse(txt_value.Text));
                    /*GetValue();
                    lb_expees.Text = GetString();*/
                    G_bl_add = true;
                    G_bl_key = true;
                }
            }
        }
    }
}
