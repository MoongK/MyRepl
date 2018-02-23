using System;

class MainClass {
  public static void Main (string[] args) {
    
    string[] names = new string[] {"c", "b", "a", "d"};
    
    Console.WriteLine(names.GetType().ToString() == "System.String[]");
    Console.WriteLine(names.GetType().BaseType.ToString() == "System.Array");
    Console.WriteLine("==========");
    
    Console.WriteLine(Stringify<string>(new string[] {"a"}) == "a");
    Console.WriteLine(Stringify<string>(new string[] {}) == string.Empty);
    Console.WriteLine(Stringify<string>(names) == "c b a d");
    Console.WriteLine(Stringify<string>(names));
    Console.WriteLine("==========");
    
    int[] scores = new int[] { 2, 4, 5, 3, 6, 8, 1, 7 }; // base class : Array
    
    Console.WriteLine(scores.GetType().ToString() == "System.Int32[]");
    Console.WriteLine(scores.GetType().BaseType.ToString() == "System.Array");
    Console.WriteLine("==========");
    
    Console.WriteLine(Stringify<int>(new int[] {2}) == "2");
    Console.WriteLine(Stringify<int>(new int[] {2,3}) == "2 3");
    Console.WriteLine(Stringify<int>(scores) == "2 4 5 3 6 8 1 7");
    Console.WriteLine("==========");
    //덜했다..
   
    
  } // eomm
  
  static string Stringify<T>(T[] ary){
    
    string s = String.Empty;
    
    for(int i=0;i<ary.Length;i++){
      if(i==ary.Length-1)
        s += ary[i].ToString();
      else
        s += (ary[i]+" ").ToString();
    }
    return s;
  }
  
} //eomc