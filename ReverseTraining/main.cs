using System;

class MainClass {
  public static void Main (string[] args) {
    
    int[] arys = {1,2,3,4,5,6};
    
    int temp;
    int last = arys.Length-1;
    
    for(int i=0;i<=arys.Length/2;i++){
      temp = arys[i];
      arys[i] = arys[last];
      arys[last] = temp;
      last--;
    }
    
    for(int i = 0;i<arys.Length;i++){
      Console.WriteLine(arys[i]);
    }
    
    
    
  }
}