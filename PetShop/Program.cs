using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
{

    public class Pet
    {
        public string Name;
        public void PrintName()
        {
            Console.WriteLine("Pet`s name is " + Name);
        }
    }

    public class Dog : Pet
    {
        new public void PrintName()
        {
            Console.WriteLine("宠物的名字是" + Name);
        }
    }

    public class Cat : Pet
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Name = "Jack";
            dog.PrintName();

            Cat cat = new Cat();
            cat.Name = "Tom";
            cat.PrintName();
        }
    }
}
