using System;
namespace ConsoleApplication1
{
    
    class EventPublisherArgs : System.EventArgs
    {
       
        public event EventHandler MyEvent; 
        public void Do()
        {
            
            if (MyEvent != null) //{ MyEvent(); //이벤트 발생 }
            {
                MyEvent(null, null);
            }
            
        }
    }
   
    class Subscriber
    {
        static void Main(string[] args)
        {
            EventPublisher p = new EventPublisher();
            
            p.MyEvent += new EventHandler(doAction);
            
            p.Do();
        }
        
        static void doAction(object sender, EventArgs e)
        {
            Console.WriteLine("MyEvent 라는 이벤트 발생...");
            string s = ((EventPublisherArgs)e).MyEventData;
            Console.WriteLine($"이벤트 발생시 넘어온 데이터 : {s}");
        }
    }
}