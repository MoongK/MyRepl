using System;

class MainClass {
  public static void Main (string[] args) {
    
    string[] names = { "one", "two", "thr", "fou" };
    int[] scores = { 48, 75, 62, 88 };
    
    for(int i=0;i<scores.Length;i++){
      Console.Write(names[i]+" "+scores[i]+" : ");
      for(int j=1;j<scores[i];j+=4){
        Console.Write("*");
      }
      if(scores[i]>=90)
        Console.WriteLine(" Great!");
      else if(scores[i]>=80)
        Console.WriteLine(" Good!");
      else if(scores[i]>=70)
        Console.WriteLine(" SoSo~");
      else
        Console.WriteLine(" need more");

    }
    
  } // End of MainMethod
} // End of MainClass