using System;

class MainClass {
  public static void Main (string[] args) {
    int i;
    int j;
    
    for(i=1;i<10;i++){
      for(j=0;j<i;j++){                   // i만큼 * 출력.. (여기선 j가 0이므로 i-1)
        Console.Write("*");
      }
      Console.WriteLine();
    }
  }
}