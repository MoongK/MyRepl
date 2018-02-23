using System;
using System.Collections;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
 
    People pe = new People();
    pe.padd("one");
    pe.padd("two");
    pe.padd("three");
    
    foreach(Person p in pe)
      Console.WriteLine(p);

 
  } //emm
} //emc

class Person {
  public string Name {get;set;}
  public Person(string name){
    Name = name;
  }
  public override string ToString() {return Name;}
}
class Person2 {
  public string Name2 {get;set;}
  public Person2(string name){
    Name2 = name;
  }
}

class People : IEnumerable/*<Person>*/ {
  public List<Person> ar = new List<Person>();
  
  public void padd(string something){
    ar.Add(new Person(something));
  }
  
  // public IEnumerator<Person> GetEnumerator() {return ar.GetEnumerator();}
  IEnumerator IEnumerable.GetEnumerator() {return ar.GetEnumerator();}
}

