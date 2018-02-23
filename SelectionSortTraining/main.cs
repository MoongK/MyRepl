using System;

class MainClass {
  public static void Main (string[] args) {

    int[] arys = {9,5,6,7,4,3,8,3,2,1};
    
    Selection s = new Selection(arys);
    
    Console.WriteLine("=============");
    for(int i=0;i<arys.Length;i++){
      Console.Write(arys[i]+" ");
    }
    Console.WriteLine();
  }
}

class Selection{
  
  public int mini;
  public int tmp;
  
  public Selection(int[] x){
    
    for(int i=0;i<x.Length;i++){
      mini = i;
      for(int j=i;j<x.Length;j++){
        if(x[j] < x[mini])
          mini = j;
      }
      tmp = x[i];
      x[i] = x[mini];
      x[mini] = tmp;
      
      for(int k=0;k<x.Length;k++){
        Console.Write(x[k]+" ");
      }
      Console.WriteLine();
    }
    
    
  }
  
  public Selection() {}

}