using System;
using System.Collections;  // ArrayList, Queue, Stack, SortedList, Dictionary, Hashtable...


class MainClass {
  public static void Main (string[] args) {
    
    Console.WriteLine("===========ArrayList==========");
    ArrayList list = new ArrayList();
    
    list.Add(1);
    Console.WriteLine((int)list[0] == 1);
    Console.WriteLine(list.Count == 1);
    Console.WriteLine(list.Add(2));
    Console.WriteLine(list.Add(3));
    Console.WriteLine(list.Count);
    
    Console.WriteLine(list.Contains(100));
    
    list.Remove(100);
    Console.WriteLine(list.Count);
    
    foreach(int i in list)
      Console.Write(i+" ");
    Console.WriteLine();
    
    
    Console.WriteLine("===========Stack==========");
    Stack stack = new Stack();
    
    stack.Push("a");
    stack.Push("b");
    stack.Push("c");
    Console.WriteLine(stack.Count==3);
    while(stack.Count>0)
      stack.Pop();
    Console.WriteLine(stack.Count==0);
    
    Console.WriteLine("===========Queue==========");
    Queue q = new Queue();
    
    q.Enqueue("James");
    q.Enqueue("Brown");
    q.Enqueue("Fox");
    Console.WriteLine(q.Count == 3);
    
    while(q.Count > 0)
      Console.WriteLine(q.Dequeue());
      
    Console.WriteLine(q.Count == 0);
    
    Console.WriteLine("===========Hashtable==========");
    
    
    
  } // eomm
} //eomc