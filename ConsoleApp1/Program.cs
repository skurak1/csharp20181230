﻿using System;
namespace Test
{
    class Tester
    {
        private int m = 88, n = 99;

        Tester(int m = 0, int n = 0)
        {
            this.m = m;     this.n = n;
        }

        static int Sum(int i = 0, int j = 0)
        {
            return i + j;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(1, 2));
            Console.WriteLine(Sum(j: 7));
            Console.WriteLine(Sum());

            Tester t1 = new Tester();
            Console.WriteLine("m={0}, n={1}", t1.m, t1.n);

            Tester t2 = new Tester(1, 2);
            Console.WriteLine("m={0}, n={1}", t2.m, t2.n);
        }
    }
 }

using System;

namespace Test
{
    class Testesr
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Minus(1, 2));
            Console.WriteLine(Minus(1));
            Console.WriteLine(Minus(i:8,))
        }
    }
}