using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test06
{
    class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child();//构造方法的调用
            Console.WriteLine("我的名字是{0}", child.Name);
            Console.WriteLine("我的名字是{0}", child.Name);
            Console.WriteLine("我的名字是{0}", child.Name);
            Console.WriteLine("我的名字是{0}", child.Name);
            //double sum;
            //sum = child.Sum(3, 4);
            //Console.WriteLine("和为{0}", sum);
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
