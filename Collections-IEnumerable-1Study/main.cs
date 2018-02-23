using System;
using System.Collections;
using System.Collections.Generic;


class MainClass {
  public static void Main (string[] args) {
    
    People p = new People();
    p.list = new List<string>(){ "ctkim", "Steve", "Brown", "Won" };
    
    foreach(var v in p){
      Console.WriteLine(v);
    }
    
    Console.WriteLine("==========");
    
  } // emm
} //emc


class People : IEnumerable<string> {
  public List<string> list {get;set;}
  
  public IEnumerator<string> GetEnumerator() { return list.GetEnumerator(); }
  IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
  
}

public class Person{
  public string Name {get;set;}
  public override string ToString() { return Name; }
}
