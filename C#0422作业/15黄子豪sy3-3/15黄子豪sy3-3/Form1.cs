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

            Person person = new Person(name,gender,yearOfBirth);
            label4.Text = person.getInfo();
        }
    }

    public class Person
    {
        string MyName;
        string MyGender;
        DateTime MyYearOfBirth;
        int age;

        public Person(string name,string gender,DateTime yearOfBirth)
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
            if(MyGender == "男" || MyGender == "男生" || MyGender == "男人")
            {
                MyName += "先生";
            }else if(MyGender == "女" || MyGender == "女生" || MyGender == "女人")
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
            else if( month >= dateTime.Month && day < dateTime.Day)
            {
                age -= 1;
            }
            //age = dateTime.Year - Convert.ToInt32(MyYearOfBirth);

            string info;
            info = MyName + "，" + "年龄为：" + age;

            return info;
        }
    }
}
