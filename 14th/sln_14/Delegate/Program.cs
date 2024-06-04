using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    delegate int MyDelegate(int a, int b); // 델리게이트(대리자) 선언

    class Calculator
    {
        public int Plus(int a, int b) { return a + b; }
        public static int Minus(int a, int b) { return a - b; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // 델리게이트(대리자) : 대리자는 메서드에 대한 참조이다.
            // C / C++ 언어에서의 함수 포인터와 유사한 기능
            // 함수 포인터보다 객체지향적이며, 타입 안정적이다.
            // 대리자를 사용하여 콜백을 구현하는 과정
            // ⑴ 대리자를 선언한다.
            // ⑵ 대리자의 인스턴스를 생성한다.
            //    인스턴스를 생성할 때는 대리자가 참조할
            //    메서드를 매개변수로 넘긴다.
            // ⑶ 대리자를 호출한다.

            Calculator calc = new Calculator();
            MyDelegate Calback;
            Calback= new MyDelegate(calc.Plus);
            Console.WriteLine(Calback(3, 4));
            //Calback = new MyDelegate(calc.Minus);
            Calback = new MyDelegate(Calculator.Minus);
            Console.WriteLine(Calback(7, 4));
        }
    }
}
