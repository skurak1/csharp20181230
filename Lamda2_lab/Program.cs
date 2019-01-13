using System;
public class Delegate1
{
    delegate double Calc(int a);

    //두개의 매개변수 a,b를 입력받아 그 합을 
    //리턴하는 익명 메소드를 델리게이트로 맊듬
    static void Main(string[] args)
    {
        int i = int.Parse(Console.ReadLine());

        Calc calc1 = delegate (int a)
        {
            return Math.Sqrt(a);
        };

        Calc calc2 = (a) => 1+1;  //람다식
        Console.WriteLine(calc1(i));
        Console.WriteLine(calc2(i));
    }
}