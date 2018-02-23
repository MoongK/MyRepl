using System;

class MainClass {
  public static void Main (string[] args) {

    Action act1 = () => Console.WriteLine("Action");
    act1();
    
    Action<int> act2 = (x) => Console.WriteLine(2*x);
    act2(3);
    
    Action<double, double> act3 = (x, y) => Console.WriteLine(x/y);
    act3(20.10, 10.5);
    
    Func<int> fn1 = () => 10;     // Func<T> ->>>> T의 개수 -1만큼의 매개변수를 받고 마지막 T형태의 리턴값을 받는다.
    Console.WriteLine(fn1() == 10);
    
    Func<int, int> fn2 = (x) => 2*x;
    Console.WriteLine(fn2(10) == 20);
    
    Func<double, double, double> fn3 = (x, y) => x/y;
    Console.WriteLine(fn3(10.1, 20.2) == 0.5);
    
    Func<int, int, int, int, int, int, int, int, int, int, int, int, int> fn13;
    fn13 = (a, b, c, d, e, f, g, h, i, j, k ,l) => a+b+c+d+e+f+g+h+i+j+k+l;
    Console.WriteLine(fn13(1,2,3,4,5,6,7,8,9,10,11,12));


  }
}