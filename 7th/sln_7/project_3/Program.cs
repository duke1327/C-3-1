﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void pyramid(int n)
            {
                for (int i = 1; i <= n; i++)
                {
                    for (int j = i; j <= n; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k <= 2 * i - 1; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            pyramid(4);
            pyramid(7);
        }
    }
}
