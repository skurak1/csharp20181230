using System;

namespace ConsoleApplication1
{
    class MyConstants
    {
        public const double Pi = 3.14; //상수, 값을 한번은 대입가능하지만 변경불가
        public const int MYAGE = 22;
    }

    class Program
    {
        static void Main(string[] args)
        {
            double radius = 2;
            double area = MyConstants.Pi * (radius * radius);
            Console.WriteLine("Area = {0}, Age={1}", area, MyConstants.MYAGE);
            //MyConstants.MYAGE = 20;   //오류
            Console.WriteLine("Area = " + area + "Age=" + MyConstants.MYAGE);
          const string name = "홍길동";
            Console.WriteLine("name : " + name);
            // name = "김길동"; // 오류
        }
    }
}