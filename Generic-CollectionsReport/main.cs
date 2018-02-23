using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {

    List<Student> Students = new List<Student>();  // 전체 학생
    Students.Add(new Student("ctkim", new List<int> {90, 80, 70}));
    Students.Add(new Student("Steve", new List<int> {100, 50, 60}));
    Students.Add(new Student("Won", new List<int> {80, 60, 80}));
    Students.Add(new Student("Brown", new List<int> {40, 90, 50}));
  
    List<Student> nonRepeaters = new List<Student>(); // 비낙제생
    List<Student> Repeaters = new List<Student>(); // 낙제생
  
    // Hint : FindAll, TrueForAll
    
    nonRepeaters = Students.FindAll(x => (x.Scores.TrueForAll(y => y >= 60) == true));
    Repeaters = Students.FindAll(x => (x.Scores.TrueForAll(y => y >= 60) == false));
    
    Console.WriteLine("==========");
    Console.WriteLine(nonRepeaters.Stringify() == "ctkim Won");
    Console.WriteLine(Repeaters.Stringify() == "Steve Brown");
  
  } // emm
} // emc

public class Student {
  public string Name {get;set;}  // 이름 별
  public List<int> Scores {get;set;}   // 점수 들
  
    public Student(string name, List<int> scores){
      Name = name;
      Scores = scores;
    }
    public Student(){}
}




public static class Extention{
  
  public static string Stringify<T>(this List<T> list){
    string s = String.Empty;
    
    for(int i=0;i<list.Count;i++){
      if(i==list.Count-1)
        s += list[i].ToString();
      else
        s += list[i]+" ";
    }
    return s;
  }
  
  public static string Stringify(this List<Student> list){   // Student 클래스 전용
    string s = String.Empty;
    
    for(int i=0;i<list.Count;i++){
      if(i==list.Count-1)
        s += list[i].Name.ToString();
      else
        s += list[i].Name+" ";
    }
    return s;
  }
}