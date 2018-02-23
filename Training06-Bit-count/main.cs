using System;

class MainClass {
  public static void Main (string[] args) {
     // Hint : Shift, AND 연산
     // Shift 연산은 if문 등에 쓰여도 실제 값을 변화시키지 않는다. (가설)
    
    Console.WriteLine(Bitcount(0)==0);
    Console.WriteLine(Bitcount(1)==1);
    Console.WriteLine(Bitcount(2)==1); //
    Console.WriteLine(Bitcount(3)==2);
    Console.WriteLine(Bitcount(4)==1); //
    Console.WriteLine(Bitcount(5)==2);
    Console.WriteLine(Bitcount(6)==2);
    Console.WriteLine(Bitcount(7)==3);
    Console.WriteLine(Bitcount(8)==1); // 
    
  } // emm
  
  static int Bitcount(uint n) {
    int count = 0;
    
    while(n>0){
      if((n&1) == 1)
        count++;
      n = n>>1;
    }
    return count;
  }
  
} // emc