﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Get_Click(object sender, EventArgs e)
        {
            string str = "\"";//定义字符串变量str并赋值为引号
            string P_strOne, P_strTwo, P_strThree;
            P_strOne = "Hello,\"C#\";";
            P_strTwo = "Hello," + '\u0022' + "C#" + '\u0022' + ";";//  '\u0022'表示一个双引号
            P_strThree = "Hello," + str + "C#" + str + ";";
            MessageBox.Show(P_strOne + "     " + P_strTwo + "     " + P_strThree);
        }
    }
}
