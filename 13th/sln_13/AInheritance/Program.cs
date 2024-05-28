using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AInheritance
{
    internal class Program
    {
        class Dog
        {
            public int Age { get; set; }
            public string Color { get; set; }

            public Dog() { this.Age = 0; }

            public void Eat() { Console.WriteLine("냠냠"); }
            public void Sleep() { Console.WriteLine("쿨쿨"); }
            public void Bark() { Console.WriteLine("왈왈"); }
        }

        class Cat
        {
            public int Age { get; set; }

            public Cat() { this.Age = 0; }

            public void Eat() { Console.WriteLine("뇸뇸"); }
            public void Sleep() { Console.WriteLine("콜콜"); }
            public void Meow() { Console.WriteLine("야옹"); }
        }

        static void Main(string[] args)
        {
            List<Dog> Dogs = new List<Dog>() { new Dog(), new Dog(), new Dog() };
            List<Cat> Cats = new List<Cat>() { new Cat(), new Cat(), new Cat() };

            foreach (var item in Dogs)
            {
                item.Eat();
                item.Sleep();
                item.Bark();
            }
            Console.WriteLine();

            foreach (var item in Cats)
            {
                item.Eat();
                item.Sleep();
                item.Meow();
            }
        }
    }
}
