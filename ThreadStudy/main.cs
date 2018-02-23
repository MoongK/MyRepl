   using System;
   using System.Threading;


class MainClass {
  public static void Main (string[] args) {
    
    // Thread t = new Thread(new ThreadStart(Todo));
    
    // Console.WriteLine("before running, Thread state : " + t.ThreadState);
    // Thread.Sleep(500);
    // t.Start();
    // Console.WriteLine("after running, Thread state: " + t.ThreadState);
    
    // t.Join();
    // Console.WriteLine("after Join, Thread state : " + t.ThreadState);
    
    Counter c = new Counter();
    Thread t = new Thread(new ThreadStart(c.Increase));
    Thread t2 = new Thread(new ThreadStart(c.Increase));
    Thread t3 = new Thread(new ThreadStart(c.Increase));
    
    t.Start();
    t2.Start();
    t3.Start();
    
    t.Join();
    t2.Join();
    t3.Join();
    
  } // emm
  
  public static void Todo() {
    for(int i=0;i<5;i++)
      Thread.Sleep(500);
    Console.WriteLine("in Todo() : " + Thread.CurrentThread.ManagedThreadId);
  }
  
} // emc

class Counter {
  public int Count {get;set;}
  private readonly object thisLock = new object();
  public void Increase() {
    lock(thisLock) {
      int temp = Count;
      Console.WriteLine("Thread {0} : {1} ", Thread.CurrentThread.ManagedThreadId, temp);
      temp = temp +1;
      Thread.Sleep(1);
      Count = temp;
    }
  }
}