using System;

class MainClass {
  public static void Main (string[] args) {
    // int s =0, i=0;
    
    // while(i<10){
    //   ++i;
    //   s+=i;
    // }
    // Console.WriteLine("sum = "+ s);
    
    
    int s2 = 0, i2 = 0;
    
    do{
      ++i2;
      if(i2%2 ==0)
        continue;
      s2 += i2;
      
    }while(i2<10);
    
    Console.WriteLine("sum2 = "+ s2);
    
  }
}