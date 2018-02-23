using System;

class MainClass {
  public static void Main (string[] args) {
    
    Cake cake = new Cake();
    
    Car car = new Car();
    car.Make = "BMW";
    car.Model = "Mini";
    car.Year = "2018";
    
    Console.WriteLine(car is int == false);
    Console.WriteLine(car is cake == false);
    Console.WriteLine(car is Car == true);
    Console.WriteLine(car is IEquatable == true);
    Console.WriteLine(car is ICloneable == true);
    Console.WriteLine(car is object == true);
    
    ICloneable ic = car as ICloneable;  // (ICloneable)car
    Console.WriteLine(ic != null);
    Console.WriteLine(ic.GetType().Name == "Car");
    
  }
}

class IEquatable {
  
}

class ICloneable {
  public string Name;
}

class Car : ICloneable{
  public string Make;
  public string Model;
  public string Year;
}

class Cake{
  
}