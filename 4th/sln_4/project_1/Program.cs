using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 입력
            /*
            string input = Console.ReadLine();
            //Console.WriteLine(input);
            Console.WriteLine(input + input); // 문자열 연결연산자
            Console.WriteLine("input" + "input");
            Console.WriteLine();
            */

            // 자료형 변환
            // 강제 자료형 변환

            /*
            var a = (int)10.0;
            var b = (float)10;
            var c = (double)10;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            */

            // 다른 자료형을 숫자로 변환
            // 문자열을 숫자로 변환할 시 오류 발생 주의

            /*
            string numberString = "57712";
            //int intNumber = (int)numberString;

            // 문자열을 숫자로 변환 : Parse

            Console.WriteLine(int.Parse(numberString));
            Console.WriteLine(int.Parse("52"));
            Console.WriteLine(long.Parse("273"));
            Console.WriteLine(float.Parse("52.251"));
            Console.WriteLine(double.Parse("52.251"));

            Console.WriteLine(double.Parse("512.12").GetType());

            //Console.WriteLine(int.Parse("abc"));
            */

            /*
            // 다른 자료형을 문자열로 변환
            Console.WriteLine(52.ToString());
            Console.WriteLine((52).ToString());

            Console.WriteLine(52.273.ToString());
            Console.WriteLine((52.123).ToString());

            // 소숫점 제거
            double number = 25.12313;
            Console.WriteLine(number.ToString("0.0"));
            Console.WriteLine(number.ToString("0.00"));
            Console.WriteLine(number.ToString("0.000"));
            */

            /*
            // 숫자와 문자열 덧셈 : 숫자가 자동으로 문자열로 변환
            Console.WriteLine(52 + 273); // 325, 덧셈 연산자
            Console.WriteLine("52" + 273); // 52273, 문자열 연결연산자
            Console.WriteLine("52" + "273");
            Console.WriteLine('a' + 'b'); // 195
            */

            /*
            // 문제1 : inch 단위를 입력받아 cm 단위를 구하는 코드를 작성하시오
            // 1inch = 2.54cm
            Console.WriteLine("inch 단위를 입력하세요 : ");
            double inch = double.Parse(Console.ReadLine());
            double cm = inch * 2.54;
            Console.WriteLine("cm 단위 변환 결과 : " + cm);
            Console.WriteLine("{0}inch는 {1}cm입니다.", inch, cm);
            Console.WriteLine($"{inch}inch는 {cm}cm입니다.");

            // 문제2 : kg 단위를 입력받아 pound 단위를 구하는 코드를 작성하시오
            // 1kg = 2.20462pound
            Console.WriteLine("kg 단위를 입력하세요 : ");
            double kg = double.Parse(Console.ReadLine());
            double pound = kg * 2.20462;
            Console.WriteLine("pound 단위 변환 결과 : " + pound);
            Console.WriteLine("{0}kg는 {1}pound입니다.", kg, pound);
            Console.WriteLine($"{kg}kg는 {pound}pound입니다.");

            // 문제3 : 원의 반지름을 입력받아 원의 둘레와 넓이를 구하는 코드를 작성하시오
            Console.WriteLine("원의 반지름을 입력하세요 : ");
            double radius = double.Parse(Console.ReadLine());
            double pi = 3.14;
            double round = radius * 2 * pi;
            double area = radius * radius * pi;
            Console.WriteLine("반지름 : " + radius + ", 둘레 : " + round + ", 넓이 : "+ area);
            Console.WriteLine("반지름 : {0}, 둘레 : {1}, 넓이 : {2}", radius, round, area);
            Console.WriteLine($"반지름 : {radius}, 둘레 : {round}, 넓이 : {area}");
            */

            // 삼항 연산자 (조건식 ? 참 : 거짓)
            Console.WriteLine("숫자를 입력하세요 : ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number % 2 == 0 ? true : false);
            Console.WriteLine(number % 2 == 0 ? "짝수" : "홀수");

            string input = Console.ReadLine();
            int number1 = int.Parse(input);
        }
    }
}
