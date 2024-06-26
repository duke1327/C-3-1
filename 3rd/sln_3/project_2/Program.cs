﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 문자열 서식
            // 서식이라는 것은 문자열이 일정한 틀과 모양을 갖추는 것을 의미한다.
            // C#은 문자열 서식화에 사용할 수 있는 간편한 두 가지를 제공한다.
            // ① 첫 번째는 string 형식의 Format() 메서드이고,
            // ② 두 번째는 문자열 보간(Interpolation)이다.

            // 1. string 형식의 Format() 메서드
            // ① 첫 번째 매개변수로 "문자열 틀"을 입력하고,
            // ② 두 번째 매개변수부터는 문자열 틀 안에 집어넣을 데이터를 차례로 입력한다.
            Console.WriteLine("학과 : " + "컴퓨터소프트웨어공학과");
            Console.WriteLine("학과 : {0}", "컴퓨터소프트웨어공학과");
            Console.WriteLine($"학과 : {"컴퓨터소프트웨어공학과"}");

            Console.WriteLine("{0}, {1}", 123, "최강컴소과"); // string 형식의 Format()
            Console.WriteLine($"{123}, {"최강컴소과"}"); // 문자열 보간

            //{첨자, 맞춤, 서식 문자열}
            Console.WriteLine("Total : {0, 10:D}", 123);
            Console.WriteLine("Total : {0, 5:D}", 123);

            Console.WriteLine("Total : {0, -7:x} {1}", 255, 265);

            //문자열 보간(Interpolation)
            // ① 문자열 틀 앞에 $ 기호를 붙인다.
            // ② 서식 항목에 첨자 대신 식이 들어간다.
        }
    }
}
