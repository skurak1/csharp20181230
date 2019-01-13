﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace 사칙연산
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("두수를 입력하세요.");
            Console.WriteLine("예 : 3,5");
            string str = Console.ReadLine();
            str.Trim();
            string[] strarr = str.Split(',');

            if (strarr.Length != 2)
                {
                Console.WriteLine("숫자2개를 콤마로 구분해서 입력하세요~");
                return;
            }

            int first, second;
            try
            {
                if(!(int.TryParse(strarr[0], out first) &
                    int.TryParse(strarr[1], out second)));
                //여기를 채워주세요 ;
                {
                    Console.WriteLine("숫자변환 실패");
                    Environment.Exit(0);
                        }
                
            }
            catch
            {
                Console.WriteLine("입력이 잘못되었습니다.");
                return;
            }
            Console.WriteLine("{0} + {1} = {2}", first, second, Calc(first, second, "+"));
            Console.WriteLine("{0} - {1} = {2}", first, second, Calc(first, second, "-"));
            Console.WriteLine("{0} * {1} = {2}", first, second, Calc(first, second, "*"));
            Console.WriteLine("{0} / {1} = {2}", first, second, Calc(first, second, "/"));
            }

        static double Calc(int first, int second, string op)
        {
            double result = 0;
            switch (op)
            {
                case "+";
                    result = first + second; break;
                case "-";
                    result = first - second; break;
                case "*";
                    result = first * second; break;
                case "/";
                    result = first / second; break;
                    //여기 채워주세요
            }
            return result;
        }

    }
}