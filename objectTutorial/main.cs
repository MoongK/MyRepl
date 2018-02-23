using System;

class MainClass {
  public static void Main (string[] args) {
    object ob = 10;     // object 는 reference
    object ob2 = "10";
    Console.WriteLine(ob.GetType());
    Console.WriteLine(ob2.GetType());
    int b = (int)ob;
    Console.WriteLine(ob==ob2);
    int x = 10;
    int y = 10;
    Console.WriteLine(x==y);
    Console.WriteLine(ob==ob2);
  }
}