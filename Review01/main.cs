using System;
using System.Collections.Generic;
using System.Linq;

delegate void Event();
delegate void calc(int a, int b);


class MainClass {
  public static void Main (string[] args) {
    
    Eventor et = new Eventor();
    
    et.man += et.test1;
    et.man += et.test2;
    et.man += et.test3;
    
    et.starter();
    
    int t = 10;
    Action<int> act1 = (x) => t= x*x;                   // Action은 <> 안의 갯수만큼 매개변수를 받음. void타입
    
    double t2 = 10;
    Action<double, double> act2 = (x, y) => t2 = x*y;
    
    int t3 = 10;                                       // Func는 <> 안의 갯수-1만큼 매개변수를 받음. <T>타입
    Func<int> fn1 = () => t3; 
    
    Func<int, int, int> fn2 = (a,b) => a+b;
    
    int t4 = 5;
    t4.FunE();
    
    Console.WriteLine("============");
    List<int> at = new List<int>();
    at.Add(10);
    at.Add(20);
    at.Add(30);
    Console.WriteLine(at.Contains(30));
    Console.WriteLine(at.Exists(x => x>20));
    Console.WriteLine(at.Find(x => x>5)); // 값(가장 처음 나온 값)
    Console.WriteLine(at.FindIndex(x => x > 5)); // 해당 값의 인덱스(가장 처음 나온 값)
    
    List<int> at2 = at.FindAll(x => x > 5);
    Console.WriteLine(at2.FindLast(x => x > 5 ));
    Console.WriteLine(at2.FindLastIndex(x => x > 5));
    
    at2.AddRange(new List<int> {1,2});
    at.AddRange(at2);
    
    List<int> at3;
    at3 = at.GetRange(0,3); 
    at3.Insert(3,30); // Insert 는 현재 사이즈 안에서만 가능 : 끼워넣는 방식이기 때문
    
    Console.WriteLine(at3.TrueForAll(x => x > 20)); // 하나라도 false라면 리턴값은 false. 모두 true가 되어야 true.
    Console.WriteLine(at3.BinarySearch(30));
    
    dynamic ts = "st";
    Console.WriteLine(ts.GetType());
    
    /*int[] numbers = {6, 4, 5, 2, 1, 3, 10, 8, 9, 7};
    var data = from num in numbers
               where num %2 == 10
               orderby num
               select num;*/  // Linq...나중에..
               
    
    calc cc = (calc)Delegate.Combine(new calc(Plus),new calc(Minus), new calc(Multiple));
    // (델리게이트 타입)Delegate.Combine(new 델리게이트타입(함수), new ......); -> 동시 호출가능.
    cc(10,20);
    
    
    
  } // emm
  
  static void Plus(int a, int b){
    Console.WriteLine("Plus : {0} + {1} = {2}",a,b,a+b);
  }
  static void Minus(int a, int b){
    Console.WriteLine("Minus : {0} - {1} = {2}",a,b,a-b);
  }
  static void Multiple(int a, int b){
    Console.WriteLine("Multiple : {0} + {1} = {2}",a,b,a*b);
  }
  
} // emc

class Eventor {

  public event Event man;
  
  public void starter() {
    man();
  }
  
  public void test1() {
    Console.WriteLine("test1!");
    
  }
  
  public void test2() {
    Console.WriteLine("test2!");
  }
  
  public void test3() {
    Console.WriteLine("test3!");
  }
  
  
}

public static class EClass{
  public static void FunE(this int x){
     Console.WriteLine(x.ToString());
    
     
  }
}