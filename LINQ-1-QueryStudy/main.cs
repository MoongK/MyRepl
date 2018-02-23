using System;
using System.Linq;
using System.Collections.Generic;


class MainClass {
  public static void Main (string[] args) {
    int[] numbers = {1,2,3,4,5,6,7,8,9,10};
    var evens = from n in numbers
                where n % 2 == 0
                select n;
    Console.WriteLine(evens.Stringify() == "2 4 6 8 10");
    
    evens = numbers.Where(n => n%2 == 0).Select(n => n);
    Console.WriteLine(evens.Stringify());
    
    List<Student> list = new List<Student> { new Student() { Name="ctkim", Height=175, Scores= new List<int>() {100,70,90}},
                                             new Student() { Name="Steve", Height=167, Scores = new List<int>() {90,80,70}},
                                             new Student() { Name="Brown", Height=180, Scores = new List<int>() {70,60,50}},
                                             new Student() { Name="Won", Height=171, Scores = new List<int>() {50,40,30}}  };

    var ss1 = from student in list
              where student.Height < 175
              orderby student.Height
              select student;
    Console.WriteLine(ss1.Stringify());
    Console.WriteLine("========");


    var ss2 = from student in list
              where student.Height < 175
              orderby student.Height
              select new {Name=student.Name, InchHeight=student.Height*0.393};
              
    foreach(var s in ss2)
      Console.WriteLine(s.Name + " " + s.InchHeight);
    Console.WriteLine();

  } //emm
} //emc

static class Extention {
  public static string Stringify<T>(this IEnumerable<T> list){
    string s = String.Empty;
    foreach(var v in list) {
      s += v.ToString() + " ";
    }
    if (s.Length > 0)
      s = s.Substring(0, s.Length-1); // 0부터 s.length-1(9)개 출력.(9번까지가 아니라 9개!) -> 0~8번이 출력됨.
    return s;
  }
}


class Student {
  public string Name {get;set;}
  public int Height {get;set;}
  public List<int> Scores {get;set;}
  
  public override string ToString() { return Name; }
}
