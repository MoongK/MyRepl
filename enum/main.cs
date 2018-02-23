using System;

class MainClass {
  enum Animal {Mouse, Cat, Bird, Dog=100, Lion };
  public static void Main (string[] args) {
    
   Animal ani = Animal.Bird;
   Console.WriteLine(ani);
   Console.WriteLine((int)ani);
   
   Animal ani2 = Animal.Dog;
   Console.WriteLine(ani2);
   Console.WriteLine((int)ani2);
   
   Animal ani3 = Animal.Lion;
   Console.WriteLine(ani3);
   Console.WriteLine((int)ani3);
   
   Animal ani4 = 0;  // 이건 왜 되냐 ㅠㅠ
   Console.WriteLine(ani4);
   Console.WriteLine((int)ani4);
   
  } // End of MainMethod 
}   // End of MainClass