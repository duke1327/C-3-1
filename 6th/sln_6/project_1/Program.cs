using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 시험 문제
            // 배열을 초기화하는 방법 4가지
            // 첫 번째 방법
            int[] scores1 = new int[5]; // new : 메모리 할당 연산자
            scores1[0] = 86;
            scores1[1] = 74;
            scores1[2] = 81;
            scores1[3] = 95;
            scores1[4] = 67;
            int sum = 0;

            // 두 번째 방법
            int[] scores2 = new int[5] { 86, 74, 81, 95, 67 };

            // 세 번째 방법
            int[] scores3 = new int[] { 86, 74, 81, 95, 67 };

            // 네 번째 방법
            int[] scores4 = { 86, 74, 81, 95, 67 };

            foreach(int i in scores1)
            {
                Console.WriteLine(i);
            }
            foreach (var score in scores2)
            {
                sum += score;
            }
            Console.WriteLine(sum);
            int average=sum/scores2.Length;
            Console.WriteLine(average);
            Console.WriteLine($"Average Score : {average}");
        }
    }
}
