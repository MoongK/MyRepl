using System;
using System.Collections;

class MainClass {
  public static void Main (string[] args) {
    
    int[] list1 = {5,8,1,2,4,6,10};
    
    Array.Sort(list1, (x,y) => x.CompareTo(y));
    
    foreach(int i in list1)
      Console.Write(i+" ");
    Console.WriteLine();
      
    string[] list2 = {"A", "B", "C", "D", "E"};
    Array.Sort(list2, (x,y) => (y.CompareTo(x)));
    
    foreach(string s in list2)
      Console.Write(s+" ");
    Console.WriteLine();
    
    Array.Reverse(list2);
      
      
    
    Car[] car = new Car[5];
    
    for(int i=0;i<car.Length;i++){
      car[i] = new Car("hello");
    }
    
    foreach(Car c in car)
      Console.Write(c.Name+ " ");
    Console.WriteLine();  
    
  } //eomm
}  //eomc

class Car{
  public string Name {get;set;}
  
  public Car(string name){
    Name = name;
  }
}