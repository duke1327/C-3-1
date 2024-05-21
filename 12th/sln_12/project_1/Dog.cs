using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1
{
    internal class Dog
    {
        public int Age { get; set; } // 속성
        public string Color { get; set; } // 속성
        
        public Dog() { this.Age = 0; } // 생성자

        public void Eat() { Console.WriteLine("냠냠"); } // 메서드
        public void Sleep() { Console.WriteLine("쿨쿨"); }
        public void Bark() { Console.WriteLine("왈왈"); }
    }
}
