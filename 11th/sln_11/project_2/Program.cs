using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 속성 (Property) : 해당 객체의 특징
            // 속성은 기본적으로 변수처럼 값을 담는 역할을 하지만
            // 그 값이 객체와 연관이 있다.
            // 속성은 객체의 데이터를 저장한다.
            /*
            BoxA boxA = new BoxA(10, 10);
            Console.WriteLine(boxA.Area());
            */
            BoxA boxA = new BoxA(-10, 10);
            Console.WriteLine(boxA.Area());
            Console.WriteLine();

            BoxB boxB = new BoxB(-10, 10);
            Console.WriteLine(boxB.Area());
            // boxB.width = 10;
            Console.WriteLine();

            BoxC boxC = new BoxC(-10, 10);
            Console.WriteLine(boxC.Area());
            Console.WriteLine();
            boxC.SetWidth(20);
            boxC.SetHeight(20);
            Console.WriteLine(boxC.Area());
            Console.WriteLine();

            BoxD boxD = new BoxD(-10, 10);
            Console.WriteLine(boxD.Area());
            boxD.Width = 10;
            boxD.Height = 20;
            Console.WriteLine(boxD.Area());
            Console.WriteLine();

            BoxE boxE = new BoxE(-10, 10);
            Console.WriteLine(boxE.Area());
            boxE.Width = 10;
            boxE.Height = 20;
            Console.WriteLine(boxE.Area());
        }
    }
}
