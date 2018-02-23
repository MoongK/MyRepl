using System;

class MainClass {
  public static void Main (string[] args) {
    
    Callback cb = sum;
    Console.WriteLine(cb(10,20) == 30);
    
    cb = delegate (int i, int j) {return i+j;};
    Console.WriteLine(cb(10,20) == 30);
    
    cb = (int i, int j) =>{ return i+j; };
    Console.WriteLine(cb(10,20) == 30);
    
    cb = (i,j) => i+j;
    Console.WriteLine(cb(10,20) == 30);
    
  }
  
  static int sum(int i, int j){
    return i+j;
  }
}

delegate int Callback(int a, int b); // 이렇게 선언을 먼저.