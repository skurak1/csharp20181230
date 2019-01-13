using System;
using System.Collections;
public class Mystack
{
    public static void Main()
    {
        Stack myStack = new Stack();
        myStack.Push("OJC");
        myStack.Push("ASIA");
        myStack.Push("Thank You!");

        Console.WriteLine("myStack 의 건수 : {0}", myStack.Count);

        Console.WriteLine(myStack.Pop());

        Console.WriteLine(myStack.Peek());

        PrintValues(myStack);
    }
        public static void PrintValues(IEnumerable myCollection)
        {
            foreach(Object obj in myCollection)
            Console.Write("{0}", obj);
           Console.WriteLine();
        }
    
}
