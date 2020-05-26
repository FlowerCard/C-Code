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
    public partial class Form5 : Form
    {
        SqlConnection sqlCon = new SqlConnection();
        SqlCommand sqlCmd = new SqlCommand();
        SqlDataAdapter sqlAda = new SqlDataAdapter();
        DataSet ds = new DataSet();
        string CString = "server=.;Data Source=DESKTOP-VSKS0LK;Initial Catalog=student_course;Persist Security Info=True;User ID=sa;Password=SIhunmie27.";
        int Sno = 0;
        string Sname = "";
        string Ssex = "";
        string Sbirth = "";
        string Sdept = "";

        public Form5()
        {
            InitializeComponent();
            sqlCon.ConnectionString = CString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Sno = int.Parse(textBox1.Text);
            Sname = textBox2.Text;
            Ssex = comboBox1.Text;
            Sbirth = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            Sdept = comboBox1.Text;
            //insert into student(sno, sname, ssex, sbirth, sdept) values(1811020202, '张三', '男', '2020-05-26', '计算机')
            string insertSql = "insert into student(sno,sname,ssex,sbirth,sdept) values(" + Sno + ",'" + Sname + "','" + Ssex + "','" + Sbirth + "','" + Sdept + "'";

        }
    }
}
