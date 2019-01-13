using System;

public class Bitoper
{
    public static void Main(string[] args)
    {
        int i = 10;     int j = 20;     int a;
        a = i & j; i = i >> 3; j = i << 3;
        Console.WriteLine("a={0}, i={1}, j={2}", a, i, j);
        Console.ReadLine();

    }
}


using System;

class LogicalAnd

    static void Main()
{
    //Method1이 false라도 Method2 실행

    Console.WriteLine("정상적인 AND:");
        if (Method1() & Method2())
        Console.WriteLine("Both methods returned true.");
    else
        Console.WriteLine("둘중 하나의 메소드는 false");

    //Method1이 false면 Method2는 실행 되지 않는다.
    Console.WriteLine("Both methods returned true.");
    else
    Console.WriteLine("둘중 하나의 메소드는 false");

    Console.WriteLine("0x{0:x}", 0xf8 & 0x3f); // 0x38
}
static bool Method1()
{
    Console.WriteLine("메소드1...");
    return false;
    }
static bool Method2()
{
    Console.WriteLine("메소드2...");
    return true;
}
}
