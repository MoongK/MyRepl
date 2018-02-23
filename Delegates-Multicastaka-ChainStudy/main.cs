using System;

delegate int Callback(int a, int b);

class MainClass {
  
  static int Sum(int i, int j) {
    Console.WriteLine("Sum!");
    return i + j;
  }
  
  static int Multiply(int i, int j) {
    Console.WriteLine("Multiply!");
    return i * j;
  }
  
  static int Power(int i, int j) {
    Console.WriteLine("Power!");
    return (int)Math.Pow((double)i, (double)j);
  }
  
  public static void Main (string[] args) {
    Callback cb = Sum;
    Console.WriteLine(cb(10, 20) == 30);
    
    cb = delegate(int i, int j) { return i+j; };
    Console.WriteLine(cb(10, 20) == 30);
    
    cb = (int i, int j) => {return i+j;};
    Console.WriteLine(cb(10,20) == 30);
    
    cb = (i,j) =>(i+j);
    Console.WriteLine(cb(10,20) == 30);
    
    Console.WriteLine("\t Chain");
    cb = Sum;
    cb += Multiply;
    cb += Power;
    
    Console.WriteLine(cb(10,3));
    
    cb -= Power;
    Console.WriteLine(cb(10,3));
    
  }
  
}