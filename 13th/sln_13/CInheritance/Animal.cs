using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CInheritance
{
    internal class Animal
    {
        public int Age { get; set; }
        public Animal() { this.Age = 0; } // this : 객체 자신을 지칭하는 키워드

        public void Eat() { Console.WriteLine("냠냠"); }
        public void Sleep() { Console.WriteLine("쿨쿨"); }
    }
}
