﻿using System;
public class Delegate1

{
    //Delegate 선언은 Action, Func로 대체할수 있다.
    //private delegate int OnjSum(int i, int j); // 1. 선언
   // private delegate void OnjSum2(int i, int j); // 1. 선언
    public static void Main(string[] args)

    {
        Delegate1 d1 = new Delegate1();

        //Sum, Sum2가 static 이 아니므로 객체참조가 필요
        //Func는 값을 리턴하는 메소드를 참조하는 시샵에서 제공하는 델리게이트
        Func<int, int, int> myMethod = d1.Sum;

        //OnjSum myMethod = new OnjSum(Delegate1.Sum);
        Console.WriteLine("두수 합 : {0}", myMethod(10,30));

        //OnjSum2 d2 = new OnjSum2(d1.Sum2);
        Action<int, int> d2 = d1.Sum2;
        d2(10, 20);

    }
    /* static int Sum(int i, int j)
    {
        return i + j;
    } */
    int Sum(int i, int j) { return i + j; }
    void Sum2(int i, int j) { Console.WriteLine($"{i}+{j}={i + j}"); }
}

