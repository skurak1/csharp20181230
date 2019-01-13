using System;
class TypeCastExample2
{
    int d;
    public static void Main()
    {
        int d = Convert.ToInt32(!(20 < 30));
        Console.WriteLine(d);
       
    }
}