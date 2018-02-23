using System;

class MainClass {
  public static void Main (string[] args) {
    
    MyDelegate<int> Plus_int = new MyDelegate<int>(plus);
    MyDelegate<float> Minus_float = new MyDelegate<float>(minus);
    MyDelegate<double> Multi_double = new MyDelegate<double>(multi);
    
    Calculator(11, 22, Plus_int);
    Calculator(22, 33, Minus_float);
    Calculator(33, 44, Multi_double);
    Console.WriteLine();

  }
  
  public static void Calculator<T>(T a, T b, MyDelegate<T> dele){
    Console.WriteLine( dele(a, b) );
  }
  
  public static void Test1(int a, int b, MyDelegate2 dele){
    
  }
  // public static void plus<T>(T a, T b) {}
  public static int plus(int a, int b) { return a+b; }
  public static float minus(float a, float b) { return a-b; }
  public static double multi(double a, double b) { return a*b; }
}

delegate T MyDelegate<T> (T a, T b);
delegate int MyDelegate2 (int a, int b);
