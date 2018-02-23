using System;

class MainClass {
  public static void Main (string[] args) {
    User[] users = new User[3] { new User("Betty", 23),
                                 new User("Susan", 20),
                                 new User("Lisa", 25) };
                                 
    Array.Sort(users, (user1, user2) => user1.Age.CompareTo(user2.Age) );
    foreach(User user in users)
      Console.Write(user.Name + user.Age + " ");
    Console.WriteLine();
  
  
    Array.Sort( users, (user1, user2) => user1.Name.CompareTo(user2.Name) );
    foreach(User user in users)
      Console.Write(user.Name + user.Age + " ");
    Console.WriteLine();

  } // eomm
} //eomc
class User{
  public string Name { get; set; }
  public int Age { get; set;}
  
  public User(string name, int age){
    Name = name;
    Age = age;
  }
  
}