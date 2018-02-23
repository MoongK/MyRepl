using System;

class MainClass {
  public static void Main (string[] args) {
    
    int[] arrays = { 9, 7, 6, 3, 8, 4, 3, 5, 2, 1 };
    foreach(int i in arrays){
      Console.Write(i+" ");
    }
    Console.WriteLine();
    
    Bubble(arrays);
    
    foreach(int i in arrays){
      Console.Write(i+" ");
    }
    Console.WriteLine();
    
  } // eomm
  
  
  
  static void Bubble(int[] arys){
    
    int temp;
    
    for(int i=arys.Length-2;i>=0;i--){
      for(int j=0;j<=i;j++){
        if(arys[j]>arys[j+1]){
          temp = arys[j];
          arys[j] = arys[j+1];
          arys[j+1] = temp;
        }
      }
    }
    
/*    for(int i=0;i<arys.Length;i++){
      Console.Write(arys[i]+" ");
    }
    Console.WriteLine();*/
  }
  
} // eomc