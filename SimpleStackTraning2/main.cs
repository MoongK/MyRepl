using System;

class MainClass {
  public static void Main (string[] args) {
    
    Stack<int> s = new Stack<int>(3);
    
    Console.WriteLine(s.top);
    Console.WriteLine(s.Push(10) == 10);
    Console.WriteLine(s.Push(20) == 20);
    Console.WriteLine(s.Push(30) == 30);
    Console.WriteLine(s.Push(40));
    Console.WriteLine(s.Pop() == 30);
    Console.WriteLine(s.Pop() == 20);
    Console.WriteLine(s.Pop() == 10);
    Console.WriteLine(s.Pop());
    
    Stack<string> s2 = new Stack<string>(3);
    Console.WriteLine(s2.top);
    Console.WriteLine(s2.Push("one") == "one");
    Console.WriteLine(s2.Push("two") == "two");
    Console.WriteLine(s2.Push("three") == "three");
    Console.WriteLine(s2.Push("four"));
    Console.WriteLine(s2.Pop() == "three");
    Console.WriteLine(s2.Pop() == "two");
    Console.WriteLine(s2.Pop() == "one");
    Console.WriteLine(s2.Pop());
    
    
    
  }
}

class Stack<T>{
  
  public T[] arys;
  public int Count { get; private set; }
  public int top;
  
  
  
  public Stack(int size){
    arys = new T[size];
    Count = 0;
    top = -1;
  }
  
  public T Push(T x){
    if(top<arys.Length-1){
    ++top;
    ++Count;
    arys[top] = x;
    Console.WriteLine(arys[top]+" "+Count+" "+top);
    return arys[top];
    }else{
      Console.WriteLine("Full Stack");
      return arys[top];
    }
  }
  
  public T Pop(){
    if(top>=0){
      T trash;
      trash = arys[top];
      // arys[top] = 0;
      Console.WriteLine(arys[top]+" "+Count+" "+top);
      --Count;
      --top;
      return trash;
    }else
      Console.WriteLine("Empty Stack");
      return arys[0];
  }
  
}

class Car {
  
}