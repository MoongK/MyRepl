using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {

  List<int> listA = new List<int>() { 8, 3, 2 };
  Console.WriteLine(listA.Stringify() == "8 3 2");
  


  } // emm
  
  static string Stringify<T>(List<T> list){
    
    string s = String.Empty;
    
    for(int i=0;i<list.Count;i++){
      if(i==list.Count-1)
        s += list[i].ToString();
      else
        s += list[i]+" ";   // 정수타입 + 문자열 -> 문자열이 되어 버림.
    }
    return s;
  }
  
} //emc

public static class Exclass{
  
  public static string Stringify<T>(this List<T> list){ // this 타입에다가 현재 함수를 집어 넣으라는 뜻
    
    string s = String.Empty;
    for(int i=0;i<list.Count;i++){
      if(i==list.Count-1)
        s += list[i].ToString();
      else
        s += list[i]+" ";
    }
    return s;
  }
  
}