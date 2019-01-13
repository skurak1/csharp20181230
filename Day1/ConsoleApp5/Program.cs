using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(+3); // unary plus, 3
        Console.WriteLine(3 + 3); // addition, 6
        Console.WriteLine(3 + .3);  // addition, 3.3
        Console.WriteLine("3" + "3"); // string concatenation, 33
        Console.WriteLine(3.0 + "3"); // 3.0을 문자열로 변환, string concatenation, 33

        Console.WriteLine(!true); // false

        byte x = 10;
        Console.WriteLine(~x); // -11

        Console.WriteLine(unchecked((short)50000)); //overflow, -15536
    }
}