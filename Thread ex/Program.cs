using System;
using System.Threading;

public class ThreadTest
{
    public void FirstWork(object name)
    {
        for(int i = 0; i < 100; i++)
        {
            Thread.Sleep(1000);
            Console.Write("F{0}", i);

        }
    }
    public void SecondWork(object name)
    {
        for(int i = 0; i < 100; i++)
        {
            Thread.Sleep(1000);
            Console.Write("S{0}", i);
        }
    }
    [MTAThread]
    public static void Main()
    {
        ThreadTest t = new ThreadTest();

        Thread first = new Thread(t.FirstWork);
        Thread second = new Thread(new ParameterizedThreadStart(t.SecondWork));

        first.Priority = ThreadPriority.Lowest;
        second.Priority = ThreadPriority.Highest;
        second.Start("First");
        first.Start("Second");     

    }
}
