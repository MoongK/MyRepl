using System;

class MainClass {
  public static void Main (string[] args) {
    // Console.WriteLine ("Hello World");
    
    // Console.WriteLine("{0:0.00}", 123.4567);
    // Console.WriteLine("{0:0.00}", 123.4);
    // Console.WriteLine(String.Format("{0:0.00}", 123.0));
    
    // Console.WriteLine("{0}{1}{2}");
    
    // string s = "ABCDE";
    
    // Console.WriteLine(s.IndexOf("CDE") == 2);
    
    // Console.WriteLine(s.IndexOf("CDE")); // 없으면 -1 반환.
    
    string s;
    s = "1000,2000,3000";
    
     string[] prices = s.Split(',');
      Console.WriteLine(prices);
     
     foreach(string price in prices)
      Console.WriteLine(price);
      
    // s.Replace(",", ", ");
    
    string[] s_s =  s.Split(',');
      
     foreach(string x in s_s)
      Console.WriteLine(x);
      
      s = "ABCDE";
      Console.WriteLine(s.Substring(1, 3) );
  }
}