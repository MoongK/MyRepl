using System;

class MainClass {
  public static void Main (string[] args) {
    
    Stack s = new Stack(3);
    
    Console.WriteLine(s.Push(10) == 10);
    Console.WriteLine(s.Count);
    Console.WriteLine(s.Push(20) == 20);
    Console.WriteLine(s.Push(30) == 30);
    Console.WriteLine(s.Pop() == 30);
    Console.WriteLine(s.Pop() == 20);
    Console.WriteLine(s.Pop() == 10);
    Console.WriteLine(s.Pop());
    
    //s.Count = 10 ; // Error !!
    
  } // EOMM
} // EOMC

class Stack {
  public int Count{ get; private set;} 
  public int[] arys;
  
  public Stack(int size){
    Count = -1;
    arys = new int[size];
  }
  
  public int Push(int x) {
    if(Count<arys.Length-1){
    ++Count;
    arys[Count] = x;
    Console.WriteLine(Count+" "+arys[Count]);
    return arys[Count];
    }
    else{
      Console.WriteLine(Count+" "+arys[Count]);
      return arys[Count];
    }  
    
  }
  
  public int Pop(){
    int trash = 0;
    if(Count>=0){
      trash = arys[Count];
      arys[Count] = 0;
      Console.WriteLine(Count+" "+arys[Count]);
      --Count;
      return trash;
    }
    else{
        Console.WriteLine("Empty Array. Count : {0}",Count);
        return Count;
    }
  }
}

