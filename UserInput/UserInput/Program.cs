using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * 接收用户输入的字符串
            string name;//姓名
            Console.Write("请输入姓名：");
            name=Console.ReadLine();//接收用户输入的字符串
            Console.WriteLine("你好,{0}!", name); 
            */

            /**
             * 接收用户输入的数组
             */
            string[] name = new string[5];//姓名数组
            int[] score = new int[5];//分数数组
            for(int i=0; i<name.Length; i++)
            {
                Console.Write("请输入第" + (i + 1) + "位同学的姓名：");
                name[i] = Console.ReadLine();
                Console.Write("请输入第" + (i + 1) + "位同学的分数：");
                score[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            //计算总分和平均分
            int sum=0, avg;//总分，平均数
            for(int i=0; i<score.Length; i++)
            {
                sum += score[i];
            }
            avg = sum / score.Length;
            Console.WriteLine("总分为{0},平均分为{1}", sum, avg);
        }
    }
}
