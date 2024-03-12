using System;
using static System.Console;

//static : 정적 전역변수 사용시 사용
//Main에 static 쓰는 이유 : 실행에 필요한 공간을 미리 메모리 공간에 올려놓기 위해 사용

namespace project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(275);
            Console.WriteLine(275);
            WriteLine(275);

            System.Console.Write(275);
            Console.Write(275);
            Write(275);

            WriteLine();

            Console.WriteLine("C# Programming");

            //주석
            //한 줄 주석
            /*
              
              여러 줄 주석 
             
             */

            Console.WriteLine(4 % 3);
            Console.WriteLine("A");
            Console.WriteLine('A');

            Console.WriteLine("안녕" + "하세요?");
            Console.WriteLine('a' + 'b');

            //이스케이프 문자
            Console.WriteLine("컴퓨터\t소프트웨어\t공학과");
            Console.WriteLine("컴퓨터\n소프트웨어\n공학과");

            //문자 선택
            WriteLine("안녕하세요."[0]);
            Console.WriteLine("안녕하세요."[5]);

            //참과 거짓
           // Console.WriteLine(52 = 273); //대입(할당) 연산자
            Console.WriteLine(52 == 273); //비교 연산자

            Console.WriteLine(DateTime.Now.Hour < 3 || 8 < DateTime.Now.Hour); //OR 논리합
            Console.WriteLine(DateTime.Now.Hour < 3 && 8 < DateTime.Now.Hour); //AND 논리곱

            int a = 10;
            int b = 20;
            int c = 10 + 20;
            Console.WriteLine(c);

            float d = 12.345F;
            double e = 234.567;

            var g = 10;
            var h = 123.456;


        }
    }
}