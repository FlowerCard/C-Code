using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15黄子豪sy3_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string name = textBox1.Text;
            string gender = textBox2.Text;
            DateTime yearOfBirth = dateTimePicker1.Value;

            Person person = new Person(name, gender, yearOfBirth);
            string tID = textBox3.Text;
            DateTime tStartYear = dateTimePicker2.Value;
            Teacher teacher = new Teacher(name,tID, tStartYear);
            label4.Text = person.getInfo() + teacher.getTInfo();


        }
    }

    public class Person
    {
        protected string MyName="";
        protected string MyGender="";
        protected DateTime MyYearOfBirth=DateTime.Now;
        protected int age;
        protected string info;

        public Person()
        {

        }

        public Person(string name, string gender, DateTime yearOfBirth)
        {
            MyName = name;
            MyGender = gender;
            MyYearOfBirth = yearOfBirth;
        }

        public int Age => age;

        public string MyName1 { get => MyName; set => MyName = value; }
        public string MyGender1 { get => MyGender; set => MyGender = value; }
        public DateTime MyYearOfBirth1 { get => MyYearOfBirth; set => MyYearOfBirth = value; }

        public string getInfo()
        {
            if (MyGender == "男" || MyGender == "男生" || MyGender == "男人")
            {
                MyName += "先生";
            }
            else if (MyGender == "女" || MyGender == "女生" || MyGender == "女人")
            {
                MyName += "女士";
            }
            else
            {
                MessageBox.Show("请输入男，或女", "性别输入错误");
                MyName += "";
            }

            DateTime dateTime = DateTime.Now;
            int year = MyYearOfBirth.Year;
            int month = MyYearOfBirth.Month;
            int day = MyYearOfBirth.Day;
            age = dateTime.Year - year;
            if (month < dateTime.Month)
            {
                age -= 1;
            }
            else if (month >= dateTime.Month && day < dateTime.Day)
            {
                age -= 1;
            }
            //age = dateTime.Year - Convert.ToInt32(MyYearOfBirth);

            info = MyName + "，" + "年龄为：" + age;

            return info;
        }

    }

    public class Teacher : Person
    {
        private string myTID;
        private DateTime myTStartYear;
        private int tAge;
        private string tInfo;

        protected string MyTID { get => myTID; set => myTID = value; }
        protected DateTime MyTStartYear { get => myTStartYear; set => myTStartYear = value; }
        protected int TAge { get => tAge; }

        public Teacher(string name,string tID,DateTime tStartYear)
        {
            this.MyName = name;
            this.MyTID = tID;
            this.MyTStartYear = tStartYear;
        }
        public string getTInfo()
        {

            DateTime dateTime = DateTime.Now;
            int jobyear = MyTStartYear.Year;
            int jobmonth = MyTStartYear.Month;
            int jobday = MyTStartYear.Day;
            tAge = dateTime.Year - jobyear;
            if (jobmonth < dateTime.Month)
            {
                tAge -= 1;
            }
            else if (jobmonth >= dateTime.Month && jobday < dateTime.Day)
            {
                tAge -= 1;
            }

            tInfo = "，工号为：" + myTID + "，教龄为：" + tAge;

            return tInfo;
        }

    }
}
