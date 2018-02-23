using System;

class MainClass {
  public static void Main (string[] args) {
    
    Car first = new Car("BMW","auto",1000,4);
    first.QnA();
    
    // 0. 정보표시
    // 1. 시동
    // 2. 사이드브레이크
    // 3. 기어
    // 4. 엑셀
    // 5. 브레이크    
    // - 종료
  
  }
}

class Car
{
  
  Car_info info;
  Car_move moving = new Car_move();
  
  public Car(string name, string gear, int engine_size, int wheels) { info = new Car_info(name, gear, engine_size, wheels); }
  public Car() { info = new Car_info(); }
  
  
  public void printCarInfo() { info.print_info(); } // 0. 정보표시
  public void start_ctr(int x) { moving.start(x); } // 1. 시동 
  public void side_ctr(int x) { moving.side_updown(x); } // 2. 사이드브레이크
  public void gear_ctr(int x) { moving.change_gear(x); } // 3. 기어
  public void accel_ctr(int x) { moving.push_accel(x); } // 4. 엑셀레이터
  public void break_ctr(int x) { moving.push_breaker(x); } // 5. 브레이크
  
  public int make_value()
  {
    int result=0;
    Console.Write("Input number(0,1) : ");
    string s_r = Console.ReadLine();
    int temp = Convert.ToInt32(s_r);
    
    if(temp == 0 || temp == 1)
      {
        result = temp;
        return result;
      }
      else{
        make_value();
        return 0;
      }
  }
  
  public int make_value2()
  {
    int result=0;
    Console.Write("Input number(-1,0,1) : ");
    string s_r = Console.ReadLine();
    int temp = Convert.ToInt32(s_r);
    switch(temp)
    {
      case 0:
        result = temp;
        break;
      case 1:
        result = temp;
        break;
      case -1:
        result = temp;
        break;
      default:
        Console.WriteLine("Wrong!");
        make_value2();
        break;
    }
    return result;
  }
  
  
  
  public void QnA() {
    Console.Write("What shall we do? : ");
    string s_q = Console.ReadLine();
    if(s_q == "-")
    {
      Console.WriteLine("Bye~");
    }else
    {
      int i_q = Convert.ToInt32(s_q);
      switch(i_q)
      {
        case 0:
          printCarInfo();
          QnA();
          break;
        case 1:
          Console.WriteLine("===Power===");
          start_ctr(make_value());
          QnA();
          break;
        case 2:
          Console.WriteLine("===side_break===");
          side_ctr(make_value());
          QnA();
          break;
        case 3:
          Console.WriteLine("===gear===");
          gear_ctr(make_value2());
          QnA();
          break;
        case 4:
          Console.WriteLine("===accel===");
          accel_ctr(make_value());
          QnA();
          break;
        case 5:
          Console.WriteLine("===foot_break===");
          break_ctr(make_value());
          QnA();
          break;
        default:
          QnA();
          break;
      }
    }
      
  } // QnA()
  
  
}  // End of Car Class



class Car_info 
{
  public string car_name, gear;
  public int engine_size, wheels;
  
  public Car_info(string name, string gear, int engine_size, int wheels)
  {
    this.car_name = name;
    this.gear = gear;
    this.engine_size = engine_size;
    this.wheels = wheels;
  }
  public Car_info()
  {
    this.car_name = "";
    this.gear = "";
    this.engine_size = 0;
    this.wheels = 0;
  }
  
  public void print_info()
  {
    Console.WriteLine("Name : " + this.car_name);
    Console.WriteLine("Gear : " + this.gear);
    Console.WriteLine("Engine : " + this.engine_size +" CC" );
    Console.WriteLine("Wheels : " + this.wheels + "WD");
  }
  
} // End of Car_info Class

class Car_move
{
  public int power=0;
  public int side_break=0, breaker=0, accel=0, on_gear=0;
  public int speed = 0;
  
  public void start(int x){                   // 1. 시동걸기
     if(this.power==0){
       switch(x)
       {
          case 0:
            Console.WriteLine("Already off.");
            break;
          case 1:
            Console.WriteLine("Power on!!");
            this.power = x;
            break;
          default:
            Console.WriteLine("Wrong.");
            break;
       }
     }else if(this.power==1){
        switch(x)
       {
          case 0:
            Console.WriteLine("Power off...");
            this.power = x;
            break;
          case 1:
            Console.WriteLine("Already on.");
            break;
          default:
            Console.WriteLine("Wrong.");
            break;
       }
     }
  }
  
  public void side_updown(int x)                    // 2. 사이드브레이크 올/내
  {
    if(this.power == 0 )
      Console.WriteLine("Power on first.");
    else
    { if(x==0){
        Console.WriteLine("Side_break is up.");
        this.side_break = x;
      }
      else if(x==1){
        Console.WriteLine("Side_break is down.");
        this.side_break = x;
      }
      else
        Console.WriteLine("Wrong.");
    }
  }
  
  public void change_gear(int x)                     // 3. 기어 바꾸기(n(0),d(1),r(-1)) on_gear
  {
    if(this.power == 0 )
      Console.WriteLine("Power on first.");
    else
    {
    if(x==0){
      this.on_gear = x;
      Console.WriteLine("Gear : N ");
    }else if(x==1){
      this.on_gear = x;
      Console.WriteLine("Gear : D ");
    }else if(x==-1){
      this.on_gear = x;
      Console.WriteLine("Gear : R ");
    }else
      Console.WriteLine("Wrong");
   }
}
  public void push_accel(int x)                      // 4. 엑셀레이터 밟/떼
  {
    if(this.power == 0 )
      Console.WriteLine("Power on first.");
    else
    {
    if(x==0){
      this.accel=x;
      Console.WriteLine("unpush accel.");
    }else if(x==1){
      this.accel=x;
      Console.WriteLine("push accel.");
      this.speed += 10;
      Console.WriteLine("Speed : " + this.speed + "Km/h");
    }else
      Console.WriteLine("Wrong");
   }
}
  
  public void push_breaker(int x)                    // 5. 브레이크 밟/떼
  {
    if(this.power == 0 )
      Console.WriteLine("Power on first.");
    else
    {
     if(x==0){
      this.breaker=x;
      Console.WriteLine("unpush breaker.");
    }else if(x==1){
      this.breaker=x;
      Console.WriteLine("push breaker.");
      if(this.speed >= 10)
        this.speed -= 10;
      Console.WriteLine("Speed : " + this.speed + "Km/h");
    }else
      Console.WriteLine("Wrong");
  }
}
  
} // End of Car_move Class
