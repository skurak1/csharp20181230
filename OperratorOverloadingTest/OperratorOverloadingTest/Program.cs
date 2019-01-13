using System;

namespace OperatorOverloadingTest
{
    class Adder
    {
        public int Value { get; set; };
    }
    class Program
    {
        static void Main(string[] args)
        {
            Adder a1 = new Adder(); a1.Value = 10;
            Adder a2 = new Adder(); a2.Value = 90;
            // 객체를 + 할수는 없다. + 는 피연산자로 숫자가 와야한다.
            Adder a3 = a1 
        }
    }
}