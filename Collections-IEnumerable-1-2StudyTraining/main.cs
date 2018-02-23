using System;
using System.Collections;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
  
  Tokens f = new Tokens("This is a sample sentence.", new Char[] {' ', '-'});
  
  foreach(string item in f)
  {
    Console.WriteLine(item);
  }
    
  } // emm
} // emc


class Tokens : IEnumerable<string> {
  public List<string> Message;
  
  public Tokens(string message, char[] ary){
    Message = new List<string>(message.Split(ary));
  }
  
   public IEnumerator<string> GetEnumerator() {return Message.GetEnumerator();}  // 제너릭
   IEnumerator IEnumerable.GetEnumerator() {return GetEnumerator();} // non제너릭

}