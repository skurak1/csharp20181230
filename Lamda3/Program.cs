﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Lamda3
{
    class Program
    {
        static bool MyWhere(int n) { return n % 2 == 1; }
        static void Main(string[] args)
        {
            int[] scores = { 30, 54, 64, 99, 11 };

            int oddScoreSum = scores.Where(n => n % 2 == 1).Sum();
            Console.WriteLine("{0} 홀수의 합", oddScoreSum);

            int oddCount = scores.Where(n => n % 2 == 1).Count();
            Console.WriteLine("{0} 홀수의 개수", oddCount);

            int Count = scores.Where(n => n > 50).Count();
            Console.WriteLine("{0} 50보다 큰수의 개수", Count);

            int Max = scores.Max();
            Console.WriteLine("{0} 배열의 최대값", Max);

            int Min = scores.Min();
            Console.WriteLine("{0} 배열의 최소값", Min);
        }


        }
    }

