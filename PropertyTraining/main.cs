using System;

class MainClass {
  public static void Main (string[] args) {
    
    // Normal_Property normal = new Normal_Property();
    // normal.Title = "hi";
    // Console.WriteLine(normal.Title);
    
    Ary_Property array = new Ary_Property();
    for(int i=0;i<5;i++){
      array[i] = i+1;
      Console.WriteLine("array[{0}] : {1}",i,array[i]);
    }
    
    
    Normal_Property normal = new Normal_Property("hello");
    Console.WriteLine(normal.Title);
    
  }
}

class Normal_Property {
  private string title;

      public string Title{
      
      get { return title; }
      set { title = value; }
      
      }
      
      public Normal_Property(string x){
        title = x;
      }
      
      public Normal_Property() {
      }

}

class Ary_Property {
  private int[] ary = new int[5];
  
  public int this[int i] {
    get { return ary[i]; }
    set { ary[i]= value; }
  }
}


