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
    public partial class Form3 : Form
    {
        SqlConnection sql = new SqlConnection();
        SqlCommand sqlCmd = new SqlCommand();
        SqlDataAdapter sqlDataAadapter = new SqlDataAdapter();
        DataSet ds = new DataSet();

        public Form3()
        {
            InitializeComponent();
            sql.ConnectionString = "server=.;Data Source=DESKTOP-VSKS0LK;Initial Catalog=student_course;Persist Security Info=True;User ID=sa;Password=SIhunmie27.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ds.Clear();
            string StuSql = "select * from student";
            sqlDataAadapter.SelectCommand = new SqlCommand(StuSql, sql);
            sqlDataAadapter.Fill(ds, "student");
            dataGridView1.DataSource = ds.Tables["student"];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ds.Clear();
            string CouSql = "select * from course";
            sqlDataAadapter.SelectCommand = new SqlCommand(CouSql, sql);
            sqlDataAadapter.Fill(ds, "course");
            dataGridView1.DataSource = ds.Tables["course"];
        }
    }
}
