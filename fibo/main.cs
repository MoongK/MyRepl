using System;

class MainClass {
  public static void Main (string[] args) {
   
   int tmp_one=1, tmp_two=1, fibo=0;
   
   int num = 10;
   
   Console.Write(tmp_one+" "+tmp_two+" ");
   
   for(int i=3;i<=num;i++){
     
    fibo = tmp_one + tmp_two;
    Console.Write(fibo+" ");
    tmp_one = tmp_two;
    tmp_two = fibo;
    
   }
   
    Console.WriteLine();
    
  }
}