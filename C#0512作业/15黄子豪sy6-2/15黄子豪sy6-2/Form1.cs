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
    public partial class Form1 : Form
    {
        SqlConnection sql = new SqlConnection();

        public Form1()
        {
            InitializeComponent();
            sql.ConnectionString = "server=.;Data Source=DESKTOP-VSKS0LK;Initial Catalog=student_course;Persist Security Info=True;User ID=sa;Password=***********";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string UserName = textBox1.Text;
            string PassWord = textBox2.Text;
            string reUserName = null;
            string rePassWord = null;
            try
            {
                string sqlUserName = "select id from admin where id = '" + UserName + "'";
                SqlCommand cmd01 = new SqlCommand(sqlUserName, sql);
                string sqlPassWord = "select psw from admin where id='" + UserName + "'";
                SqlCommand cmd02 = new SqlCommand(sqlPassWord, sql);
                sql.Open();
                string reUserName = cmd01.ExecuteScalar().ToString();
                string rePassWord = cmd02.ExecuteScalar().ToString();
                sql.Close();
            }
            catch
            {
            }
               
            if (UserName != reUserName || PassWord != rePassWord)
            {
                MessageBox.Show("账号或密码错误", "提示");
            }
            else
            {
                MessageBox.Show("登录成功", "提示");
            }
        }
    }
}
