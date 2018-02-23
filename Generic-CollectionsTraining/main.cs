using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    
    List<int> listA = new List<int>() { 8, 3, 2 };
    
    int[] arrayA = listA.ToArray();
    Console.WriteLine(Stringify(arrayA) == "8 3 2");
    Console.WriteLine(listA.ToArray().Stringify() == "8 3 2");
    Console.WriteLine(listA.Stringify() == "8 3 2");
    
    List<int> listB = new List<int>( listA );
    Console.WriteLine( listB.Stringify() == "8 3 2");
    
    listB = new List<int>() { 5, 7 };
    listA.AddRange(listB);
    Console.WriteLine( listA.Stringify() == "8 3 2 5 7");
    
    listA.Sort();
    Console.WriteLine( listA.ToArray().Stringify() == "2 3 5 7 8");
    List<int> sortedList = new List<int> ( listA );
    Console.WriteLine( sortedList.BinarySearch(3, new MyComparer()) == 1);
    
    
    

  } // emm
  
  static string Stringify<T>(T[] ary){
    
    string s = String.Empty;
    
    for(int i=0;i<ary.Length;i++){
      if(i==ary.Length-1)
        s += ary[i].ToString();
      else
        s += ary[i]+" ";
    }
    return s;
  }
  
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
  
  public static string Stringify<T>(this T[] ary){
    
    string s = String.Empty;
    
    for(int i=0;i<ary.Length;i++){
      if(i==ary.Length-1)
        s += ary[i].ToString();
      else
        s += ary[i]+" ";
    }
    return s;
  }
  
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

class MyComparer : IComparer<int>{
  public int Compare(int x, int y) { return x.CompareTo(y); }
}