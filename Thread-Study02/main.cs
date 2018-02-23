using System;
using System.Threading;
using System.Threading.Tasks;


class MainClass {
  public static void Main (string[] args) {
    
    Task<string> task = new Task<string>( () => {
      Thread.Sleep(1000);
      Console.WriteLine("in Task : " + Thread.CurrentThread.ManagedThreadId);
      return "Task result";
    });
    task.Start();
    
    Console.WriteLine("in Main");
    Console.WriteLine( task.Result == "Task result" );


    Task<string> task2 = new Task<string>( () => {
      Thread.Sleep(1000);
      Console.WriteLine("in Task2 : " + Thread.CurrentThread.ManagedThreadId);
      return "Task2 result";
    });
    task2.Start();
    
    Console.WriteLine("in Main2");
    Console.WriteLine( task2.Result == "Task2 result" );
    
    Task<string> taskChain = new Task<int>.Run() => {
      Console.WriteLine("1 Task Chain({0}", Thread.CurrentThread.ManagedThreadId);
      Thread.Sleep(100);
      return 100;
    }
  } // emm
} // emc
