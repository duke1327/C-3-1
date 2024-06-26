﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //복합 대입 연산자
            int output = 10;
            output += 52; // output = output + 52;

            Console.WriteLine(output);

            output *= 52; // output = output * 52;
            Console.WriteLine(output);

            //+(문자열 연결 연산자)
            string input = "Hello ";
            input += "World~";
            Console.WriteLine(input);

            //증감 연산자
            /*int number1 = 10;
            number1++;
            Console.WriteLine(number1); // 11
            number1--;
            Console.WriteLine(number1); // 10
            ++number1;
            Console.WriteLine(number1); // 11
            --number1;
            Console.WriteLine(number1); // 10*/

            /*int number2 = 20;
            Console.WriteLine(number2); // 20
            Console.WriteLine(number2++); // 20출력 -> 21
            Console.WriteLine(number2--); // 21출력 -> 20
            Console.WriteLine(number2); // 20

            Console.WriteLine(++number2); // 20 -> 21출력
            Console.WriteLine(--number2); // 21 -> 20출력
            Console.WriteLine(number2); // 20*/

            /*int number3 = 30;
            Console.WriteLine(number3);
            number3++; // 31
            number3--; // 30
            Console.WriteLine(number3);

            --number3; // 29
            ++number3; // 30
            Console.WriteLine(number3);*/

            //자료형

            int _int = 275;
            long _long = 52273103365;
            float _float = 52.273f;
            double _double = 52.273;
            char _char = '글';
            string _string= "문자열";

            Console.WriteLine(_int.GetType());
            Console.WriteLine(_long.GetType());
            Console.WriteLine(_float.GetType());
            Console.WriteLine(_double.GetType());
            Console.WriteLine(_char.GetType());
            Console.WriteLine(_string.GetType());

            //var : 입력되는 데이터에 따라서 자동으로 지정
            var numberA = 100;
            var numberB = 100.13f;
            var numberC = 100.13;

            
        }
    }
}
