using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test06
{
    class Child
    {
        private string name;
        private Gender sex=Gender.男;
        private int age;
        private int height;

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        /// <summary>
        /// 性别
        /// </summary>
        public Gender Sex
        {
            get
            {
                return sex;
            }

            set
            {
                sex = value;
            }
        }

        /// <summary>
        /// 年龄
        /// </summary>
        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        /// <summary>
        /// 身高
        /// </summary>
        public int Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        }

        /// <summary>
        /// 求和
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public double Sum(double x,double y)
        {
            double sum = x + y;
            return sum;
        }

        public Child()
        {
           
        }


        /// <summary>
        /// this 当前对象
        /// </summary>
        /// <param name="name"></param>
        /// <param name="sex"></param>
        /// <param name="age"></param>
        public Child(string name,Gender sex,int age)
        {
            this.name = name;
            this.sex = sex;
            this.age = age;
        }

        public Child(string name,int age)
        {
            Name = name;
            Age = age;
        }
    }
}
