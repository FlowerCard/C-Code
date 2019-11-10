using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test04
{
    /// <summary>
    /// 小朋友
    /// </summary>
    class Child
    {
        public string _name;//姓名
        public string _sex;//性别
        public int _age;//年龄
        public int _height;//身高

        /// <summary>
        /// 踢足球
        /// </summary>
        public void PlayBall()
        {
            Console.WriteLine("耶！我是小小C罗");
        }
    }
}
