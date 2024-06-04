using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortWithDelegate
{
    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }

    internal class Program
    {
        // 메서드는 프로그램 안으로 넣을 것
        static int SortWithPrice(Product a, Product b) // Delegate로 사용 : 미리 만들어서 제공하는 키워드
        {
            return a.Price.CompareTo(b.Price); // CompareTo : 비교
        }

        static int SortWithName(Product a, Product b)
        {
            return a.Name.CompareTo(b.Name);
        }

        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product() {Name="감자",Price=3000},
                new Product() {Name="고구마",Price=4000},
                new Product() {Name="호박",Price=2000},
                new Product() {Name="당근",Price=3500},
                new Product() {Name="연근",Price=2500}
            };

            // 가격 정렬
            products.Sort(SortWithPrice);

            // 출력
            foreach (var item in products)
            {
                Console.WriteLine(item.Name + " : " + item.Price);
            }
            Console.WriteLine();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine();

            // 이름 정렬
            products.Sort(SortWithName);

            foreach (var item in products)
            {
                Console.WriteLine(item.Name + " : " + item.Price);
            }
        }
    }
}
