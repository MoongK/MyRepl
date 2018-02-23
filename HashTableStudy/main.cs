using System;
using System.Collections;

class MainClass {
  public static void Main (string[] args) {
    
    Hashtable ht = new Hashtable();
    User[] user = new User[10] { new User("One", "M", 10),
                                new User("Two", "W", 20),
                                new User("Three","M", 30),
                                new User("Four","W", 40),
                                new User("Five","M", 50),
                                new User("Six","W", 10),
                                new User("Seven","M", 20),
                                new User("Eight","W", 30),
                                new User("Nine","M", 40),
                                new User("Ten","W", 50) };
                                
    
    ht.Add(1,user[0]);
    ht.Add(2,user[1]);
    ht.Add(3,user[2]);
    
    Console.WriteLine(ht.Count);
    
    for(int i=1;i<=user.Length;i++){
      if(ht.ContainsKey(i)==false)
        ht.Add(i,user[i-1]);
      else
        Console.WriteLine("Already exists.");
    }
    Console.WriteLine(ht.Count);

    for(int i=1;i<=10;i++){
      // Console.Write(((User)ht[i]).Name+"-"+((User)ht[i]).Gender+"-"+((User)ht[i]).Age+" "); // 아래와 같은 문장.
      Console.Write((ht[i]as User).Name+"-"+(ht[i]as User).Gender+"-"+(ht[i]as User).Age+" ");
    }
      Console.WriteLine();
      Console.WriteLine("======!!");
    
    try{
      // throw new Exception();
      ht.Add(1,user[1]);
    }
    catch(Exception e){
      Console.WriteLine(e.Message);
      Console.WriteLine("Already exist.");
      
    }
    
  } // eomm
} // eomc

class User{
  public string Name {get;set;}
  public string Gender {get;set;}
  public int Age {get;set;}
  
  public User(string name, string gender, int age){
    Name = name;
    Age = age;
    Gender = gender;
  }
  
  public User() {}
}