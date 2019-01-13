using System;
namespace IsAsTest
{
    class Emp { }
    class Programmer : Emp { }
    class Program
    {
        static void Main(string[] args)
        {
            Programmer p = new Programmer();
            if (p is Emp)
            {
                if (p is Emp) Console.WriteLine("p is Emp"); // 하위클래스 is a 상위클래스 => OK
                else Console.WriteLine("p is not Emp"); // p를 Emp로 형변환하고 OK면 Emp를 리턴,
                                                                   // 

                Emp e = p as Emp;
                if (e != null)
                    Console.WriteLine(" p가 Emp로 형변환 OK");
            }
  
        }
    }
}
