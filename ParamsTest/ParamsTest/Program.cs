using System;
namespace ParamsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum());
            Console.WriteLine(Sum(1, 2));
            Console.WriteLine(Sum(1,2,3,4,5,6,7,8,9,10))    
        }
    }
        
}