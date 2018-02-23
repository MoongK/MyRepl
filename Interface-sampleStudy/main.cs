using System;

class MainClass {
  public static void Main (string[] args) {
    
    Car car = new Car();
    
    car.Make = "BMW";
    car.Model = "Mini";
    car.Year = "2018";
    
    Car car2 = new Car();
    
    car2.Make = "Tesla";
    car2.Model = "X";
    car2.Year = "2018";
    
    Console.WriteLine(car != car2);
    Console.WriteLine(car.Equals(car2)==true);
    
    Car car3 = car.Clone();
    Console.WriteLine(car.Equals(car3)==true);
    
    Console.WriteLine(car.Stringify() == "BMW, Mini, 2018");
    
    
  } //eomm
} //eomc

interface IEquatable { // 인터페이스는 내부 인수들이 무조건 public(public 외의 접근제한자는 불가능)
  bool Equals(Car car);
  
}

interface ICloneable {
  Car Clone();
}

interface _Stringify {
  string Stringify();
}

class Car : IEquatable, ICloneable, _Stringify {
  public string Make { get; set; }
  public string Model { get; set; }
  public string Year { get; set; }
  
    public bool Equals(Car x) {
      if(this.Make == x.Make && this.Model == x.Model && this.Year == x.Year)
        return true;
      else
        return false;
    }
    
    public Car Clone() {
      Car x = new Car();
      x.Make = this.Make;
      x.Model = this.Model;
      x.Year = this.Year;
      
      return x;
    }
    
    public string Stringify() {
      string x;
    
       x = stringer.Make+", "+stringer.Model+", "+stringer.Year;
  
      return x;
    }
    
}