using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_5
{
    internal class Program
    {
        class Product
        {
            public string name;
            public int price;
        }

        static void Main(string[] args)
        {
            Product p = new Product();

            
            p.name = "감자";
            p.price = 5000;
            Console.WriteLine(p.name + " : " + p.price + "원");
            

            Product pA = new Product() { name = "감자", price = 5000 };
            Product pB = new Product() { name = "고구마", price = 6000 };
            Product pC = new Product() { name = "호박", price = 4000 };

            Console.WriteLine($"{pA.name} : {pA.price}원");
            Console.WriteLine($"{pB.name} : {pB.price}원");
            Console.WriteLine($"{pC.name} : {pC.price}원");
        }
    }
}
