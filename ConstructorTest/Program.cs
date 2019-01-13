using System;


namespace ConstructorTest
{
    class Emp
    {
        string name;
        ~Emp() { Console.WriteLine("EMP 소멸됨..." + name); } //소멸자 Finalize
 
        public Emp(string name = "홍길이") //생성자, 생성자 오버로딩
        {
            this.name = name;
            Console.WriteLine("EMP 객체생성..." + name);
        }
    }
   
    class EmpTest

    {
        static void Main(string[] args)
        {
            Emp e = new Emp();
            Emp e1 = new Emp("광개토");
        }
    }
}
