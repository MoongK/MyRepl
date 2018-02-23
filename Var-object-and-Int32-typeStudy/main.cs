using System;

class MainClass {
  public static void Main (string[] args) {          // var type : 지역변수로만 가능.
    
    var price = 10000;
    
    Console.WriteLine(price == 10000);
    Console.WriteLine(price.GetType().ToString() == "System.Int32");          // . . . 무제한 중첩 가능?
    
    Int32 i32 = 10000;
    Console.WriteLine(i32.GetType().ToString() == "System.Int32");
    
    object obj = 70;           // 객체
    
    Console.WriteLine(obj.GetType().ToString() == "System.Int32");
    
    
    Car car = new Car();
    car.name = 10;
    Console.WriteLine(car.first());
    Console.WriteLine(car.second()=="10");
    Console.WriteLine(car.third());
    
    Console.WriteLine(car.first().second());
    
    
  }
}

class Car {
  public int name;
  
  
  public Car first(){
    return this;
  }
  
  public string second(){
    return this.name.ToString();
  }
  
  public string third(){
    return this.name+"!!";
  }
}