using System;

class MainClass {
  
  delegate bool MyDelegate<T>(int index, T user);
  
  static int FindIndexOf(User[] ary, MyDelegate<string> dele){
    for(int i=0;i<ary.Length;i++){
      if(dele(i, ary[i].Name))
        return i;
    }
    return -1;
  }
  
  static int CountOf(User[] ary, MyDelegate<int> dele){
    int count = 0;
    for(int i = 0;i<ary.Length;i++){
      if(dele(i, ary[i].Age)){
        count++;
      }
    }
    return count;
  }
  
  public static void Main (string[] args) {

    User[] list = new User[4];
    list[0] = new User("Daniel", 27);
    list[1] = new User("Outsider", 30);
    list[2] = new User("Wolf", 17);
    list[3] = new User("Song", 20);
    
    Console.WriteLine(FindIndexOf(list, (index, user) => (user == "Wolf") ) == 2); // Wolf 가 들어있는 index 값 리턴
    Console.WriteLine(FindIndexOf(list, (index, user) => (user == "Kim") ) == -1); // Kim 이들어있는 index , 없으면 -1 리턴
    
    Console.WriteLine(CountOf(list, (index, user) => (user >= 20) ) == 3); // 나이가 20 이상인 사람이 몇 명인지 리턴
    Console.WriteLine(CountOf(list, (index, user) => (user >= 10) ) == 4); // 나이가 10 이상인 사람이 몇 명인지 리턴
    Console.WriteLine(CountOf(list, (index, user) => (user > 100) ) == 0); // 나이가 100보다 큰 사람이 몇 명인지 리턴
    
    
  } // eomm
} // eomc

class User {

  public string Name;
  public int Age;
  
  public User(string name, int age){
    this.Name = name;
    this.Age = age;
  }
  
  public User(){}
  
}