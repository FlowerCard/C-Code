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
    public partial class Form4 : Form
    {
        SqlConnection sql = new SqlConnection();
        SqlCommand sqlCmd = new SqlCommand();
        SqlDataAdapter sqlAda = new SqlDataAdapter();
        DataSet ds = new DataSet();
        string StuName = "";
        string CouName = "";

        string TxtSql = "select student.sno as 学号,student.sname as 姓名,course.cname as 课程,sc.grate as 成绩 from (student join sc on student.sno=sc.sno) join course on sc.cno=course.cno ";

        public Form4()
        {
            InitializeComponent();
            sql.ConnectionString = "server=.;Data Source=DESKTOP-VSKS0LK;Initial Catalog=student_course;Persist Security Info=True;User ID=sa;Password=SIhunmie27.";
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            ds.Clear();
            sqlAda.SelectCommand = new SqlCommand(TxtSql, sql);
            sqlAda.Fill(ds, "ZongHe");
            dataGridView1.DataSource = ds.Tables["ZongHe"];
            string[] comboText = { "计算机", "外语" };
            for(int i = 0; i < comboText.Length; i++)
            {
                comboBox1.Items.Add(comboText[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ds.Clear();
            string TxtSql02 = TxtSql;
            StuName = textBox1.Text;
            CouName = comboBox1.Text;
            if (StuName != "" && CouName != "")
            {
                TxtSql02 += "where student.sname='" + StuName + "' and " + "course.cname='" + CouName + "'";
            }else if (StuName != "")
            {
                TxtSql02 += "where student.sname='" + StuName + "'";
            }
            else if (CouName != "")
            {
                TxtSql02 += "where course.cname='" + CouName + "'";
            }
            else
            {
                TxtSql02 = TxtSql;
            }
            sqlAda.SelectCommand = new SqlCommand(TxtSql02, sql);
            sqlAda.Fill(ds, "ZongHe");
            dataGridView1.DataSource = ds.Tables["ZongHe"];
        }
    }
}
