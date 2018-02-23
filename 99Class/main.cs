using System;

class MainClass {
  public static void Main (string[] args) {
   
   int i,j;
   
   for(i=1;i<10;i++){
     for(j=1;j<5;j++){
       Console.Write("|{0} X {1} = {2}|\t",j,i,i*j);
     }
     Console.WriteLine();
   }
   
  }
}