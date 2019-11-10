using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test04
{
    class Program
    {
        static void Main(string[] args)
        {
            Child xiaoMing = new Child();//实例化Child对象
            xiaoMing._name = "小明";
            xiaoMing._age = 18;
            xiaoMing._height = 180;
            xiaoMing._sex = "男";
            Console.WriteLine("我叫" + xiaoMing._name + "，我今年" + xiaoMing._age + "岁");
            xiaoMing.PlayBall();//调用方法
        }
    }
}
