using System;

class MainClass {
  public static void Main (string[] args) {
    
    int a = 3;
    int b = 4;
    bool result;
    
    result = a<b && b<5;
    Console.WriteLine("result : {0}",result);  // result == true
    result = a>b && b<5; 
    Console.WriteLine("result : {0}",result);  // result == false
    result = a>b || b<5;
    Console.WriteLine("result : {0}",result);  // result == true
    result = !result;
    Console.WriteLine("result : {0}",result);  // result == false
    
    int x = 30;
    string x_result = a == 30 ? "yes" : "no";
    Console.WriteLine(x_result);
    Console.WriteLine(x.GetType());
    Console.WriteLine(x_result.GetType());
    
    // int a = 10;
    // Console.WriteLine(a++);
    // Console.WriteLine(++a);
    
    // Console.WriteLine(a--);
    // Console.WriteLine(--a);
    
    
    
    
    // int x = 128;
    // Console.WriteLine("x = {0}",x);
    
    // sbyte y = (sbyte)x;
    // Console.WriteLine("y = {0}",y);
    
    // float a = 69.6875f;
    // Console.WriteLine("a : {0}",a);
    
    // double b = (double)a;
    // Console.WriteLine("b : {0}",b);
    
    // Console.WriteLine("69.6875 == b : {0}",69.6875==b);    // 끝에 비교연산자 - > bool형.
    
    // float x = 0.1f;
    // Console.WriteLine("x : {0}",x);
    
    // double y = (double)x;
    // Console.WriteLine("y : {0}",y);
    
    // Console.WriteLine("0.1 == y : {0}",0.1==y);           // 위와 마찬가지.
    
    // float a = 0.9f;
    // int b = (int)a;
    // Console.WriteLine(b);
    
    // float c = 1.1f;
    // int d = (int)c;
    // Console.WriteLine(d);
    
    // string a = "12345";
    // int b = int.Parse(a);
    // Console.WriteLine(b);
    
    // int c = 3;
    // string d = c.ToString();
    // Console.WriteLine(d);
    
    // Console.WriteLine("Type of a : {0}",a.GetType());
    // Console.WriteLine("Type of b : {0}",b.GetType());
    // Console.WriteLine("Type of c : {0}",c.GetType());
    // Console.WriteLine("Type of d : {0}",d.GetType());
    
  }
}