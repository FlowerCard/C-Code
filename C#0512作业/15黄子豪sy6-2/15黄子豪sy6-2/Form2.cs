using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _15黄子豪sy6_2
{
    public partial class Form2 : Form
    {
        SqlConnection sql = new SqlConnection();
        public Form2()
        {
            InitializeComponent();
            sql.ConnectionString = "server=.;Data Source=DESKTOP-VSKS0LK;Initial Catalog=student_course;Persist Security Info=True;User ID=sa;Password=SIhunmie27.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql.Open();
            label2.Text = sql.State.ToString();
            sql.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sql.Close();
            label2.Text = sql.State.ToString();
        }
    }
}
