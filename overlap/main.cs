using System;

class MainClass {
  public static void Main (string[] args) {
                                      //전제조건 : p1 < p2 && q1 < q2
    Console.Write("Input p1 : ");
    string s_p1 = Console.ReadLine();
    int p1 = Convert.ToInt32(s_p1);
    Console.Write("Input p2 : ");
    string s_p2 = Console.ReadLine();
    int p2 = Convert.ToInt32(s_p2);
    
    Console.Write("Input q1 : ");
    string s_q1 = Console.ReadLine();
    int q1 = Convert.ToInt32(s_q1);
    Console.Write("Input q2 : ");
    string s_q2 = Console.ReadLine();
    int q2 = Convert.ToInt32(s_q2);
    
    //  p1~~~~~~~~~~~~~~~~p2      q1~~~~~~~~~~~~~~~~q2
    //  p1~~~~~~~~~~~~~~~~p2      q2~~~~~~~~~~~~~~~~q1
    //  p2~~~~~~~~~~~~~~~~p1      q1~~~~~~~~~~~~~~~~q2
    //  p2~~~~~~~~~~~~~~~~p1      q2~~~~~~~~~~~~~~~~q1
    
    //  q1~~~~~~~~~~~~~~~~q2      p1~~~~~~~~~~~~~~~~p2
    //  q1~~~~~~~~~~~~~~~~q2      p2~~~~~~~~~~~~~~~~p1
    //  q2~~~~~~~~~~~~~~~~q1      p1~~~~~~~~~~~~~~~~p2
    //  q2~~~~~~~~~~~~~~~~q1      p2~~~~~~~~~~~~~~~~p1
    
    //  q1~~~~p1~~~~~p2~~~q2      p1~~~~q1~~~~q2~~~~p2
    
    // =====================오버랩 검사==================
    
     if(p1<q1){
       if(p2<q1 && p2<q2){
         Console.WriteLine("Not overlapped.");
       }else{
          Console.WriteLine("Overlapped!");
       }
     }else{  // p1 > q1
       if(p1>q2 && p2>q2){
         Console.WriteLine("Not overlapped.");
       }else{
         Console.WriteLine("Overlapped!");
       }
     }
      
    
    
  }
}

 