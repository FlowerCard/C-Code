using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test06
{
    struct Dog
    {
        //类中可以有出事时，结构中不能用
        string _name;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public void Sing()
        {
            Console.WriteLine("汪汪");
        }


        //结构中只能定义带参数构造
        public Dog(string name)
        {
            _name = name;
        }
    }
}
