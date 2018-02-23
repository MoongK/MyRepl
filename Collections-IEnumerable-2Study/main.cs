using System;
using System.Collections; // Non 제네릭 IEnumerable
using System.Collections.Generic; // 제네릭 IEnumerable

class MainClass {
  public static void Main (string[] args) {
    
    List<string> ss = new List<string>() {"1", "2", "3", "4", "5"};
    
    Console.WriteLine(ss.Stringify());
    
    
  } // emm
  
} // emc

 

class Person {
  public string Name {get; set;}
}

class People : IEnumerable<Person> {
  public List<Person> list {get;set;}
  
  public IEnumerator<Person> GetEnumerator() { return new PersonEnumerator(list); }
  
  IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
  
  private class PersonEnumerator : IEnumerator<Person> {
    int position = -1;
    List<Person> list;
    
    public PersonEnumerator(List<Person> list) {this.list = list;}
    
    public Person Current {
      get { return list[position]; }
    }
    
    object IEnumerator.Current {
      get { return Current; }
      
    }
    
    public bool MoveNext() {
      if(position < list.Count-1) {
        position++;
        return true;
      }else
        return false;
    }
    public void Reset() { position = -1; }
    public void Dispose() { }
    
  }
}



static class Extention {
  public static string Stringify<T>(this IEnumerable<T> list){
    string s = String.Empty;
    foreach(var v in list) {
      s += v.ToString() + " ";
    }
    Console.WriteLine(s.Length);
    if (s.Length > 0)
      s = s.Substring(0, s.Length-1); // 0부터 s.length-1(9)개 출력.(9번까지가 아니라 9개!) -> 0~8번이 출력됨.
    return s;
  }
}