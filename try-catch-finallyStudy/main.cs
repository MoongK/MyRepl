using System;

class MainClass {
  public static void Main (string[] args) {
    
    Calc c = new Calc();
    Console.WriteLine(c.divide(10,1) == 10);
    
    Console.WriteLine(c.divide(10,0));
    c.divide(10,0);
    
  }
}




class Calc {
  public float divide(int x, int y) {
    float z = 0;
    try {
      z = x / y;
      return z;
    }catch(Exception e) {
      Console.WriteLine(e.Message);
      return z;
    }
  }
}