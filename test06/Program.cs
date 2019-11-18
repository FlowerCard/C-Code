using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test06
{
    class Program
    {
        static Dog dog;
     
        static void Main(string[] args)
        {
            //Child child = new Child("田翠花","女",5);//构造方法的调用

            //Console.WriteLine("我的名字是{0}", child.Name);
            //Console.WriteLine("我是{0}生", child.Sex);
            //Console.WriteLine("我的年龄是{0}", child.Age);
            //Console.WriteLine("我的名字是{0}", child.Name);
            //double sum;
            //sum = child.Sum(3, 4);
            //Console.WriteLine("和为{0}", sum);

            //用有参数构造方法初始化对象
            //Child child1 = new Child("小白","女",16);

            //用吴灿酥构造方法初始化对象
            //Child child2 = new Child();
            //child2.Name = "胡小梅";
            //child2.Sex = "女";
            //child2.Age = 5;
            //child2.Height = 140;

            //用对象初始化器初始化对象
            //Child child3 = new Child { Name = "周芷若", Age = 5 };
            //Console.WriteLine("我叫{0}，今年{1}岁啦！", child3.Name, child3.Age);

            //Child child1 = new Child();
            //child1.Name = "张小明";
            //Child child2 = child1;
            //child2.Name = "刘小勇";
            //Console.WriteLine(child1.Name);
            //Console.WriteLine(child2.Name);

            //Dog dog = new Dog();
            //dog.Name = "小白";
            //Console.WriteLine("我叫" + dog.Name);
            //dog.Sing();

            //Child child1 = new Child("梁晓雪", Gender.女, 4);
            //Child child2 = new Child("刘小牛", (Gender)0, 5);
            //Console.WriteLine("我叫{0},我是{1}生", child1.Name, child1.Sex);
            //Console.WriteLine("我叫{0},我是{1}生", child2.Name, child2.Sex);

            Child c1 = new Child("刘有才",Gender.男,3);
            //Growth(c1);//按引用传参,方法修改形参，通常实参也会被修改
            int age = c1.Age;
            //Growth(ref age);//按值传参，方法修改形参，实参不会被修改
            Console.WriteLine("我现在{0}岁了", age);
            int ly, ny;//去年的年龄，明年的年龄
            Growth(age, out ly, out ny);
            Console.WriteLine("我明年{0}岁,去年{1}岁", ny, ly);
        }

        /*
         * ref 传参
         * out 获取结果，返回多个值
         */

        /// <summary>
        /// 长大一岁
        /// </summary>
        /// <param name="child"></param>
        //static void Growth(Child child)//引用类型参数，按引用传参
        //{
        //    child.Age++;
        //    Console.WriteLine("1奥！我又长大了一岁！");
        //}

        static void Growth( ref int age)//值类型参数，按值传参
        {
            age++;
            //Console.WriteLine("2奥！我又长大了一岁！"+age);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="age">现在的年龄</param>
        /// <param name="lastYear">去年的年龄</param>
        /// <param name="nextYear">明年的年龄</param>
        static void Growth(int age,out int lastYear,out int nextYear)
        {
            lastYear = age - 1;
            nextYear = age + 1;
        }
    }
}

//构造方法的作用：为属性赋值
//如果没有显示定义构造方法，则会有一个默认的无参数的构造方法
//如果显示定义了构造方法，则没有默认构造方法
//只能用new 方法名()的形式调用构造方法
//构造方法通常声明称public
//构造方法没有返回值类型
//构造方法名与类名相同

    /*
     * 结构Struct
     * 1、结构是值类型（类是应用类型）
     * 2、结构中可以定义字段、属性和方法
     * 3、不能为结构中的字段赋初始值
     * 4、结构的构造方法中必须为所有字段赋值
     * 5、不能为结构显式定义无参数的构造方法
     * 6、结构类型的对象可以不实例化
     */
