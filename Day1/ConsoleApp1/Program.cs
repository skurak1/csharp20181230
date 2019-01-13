using System;
class TypeCastExample2{
    public static void Main()    {
        int a = 50000;
        try {
            short b = checked((short)a); // overflow를 검사하여 예외를 발생시킴
        }
        catch (Exception e)
        {
            Console.WriteLine("예외 : {0}", e.StackTrace);
            Console.WriteLine("-------------------------");
            Console.WriteLine("예외 : {0}", e.Message);
        }
    }
}