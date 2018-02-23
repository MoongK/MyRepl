using System;

class MainClass {
  public static void Main (string[] args) {
    
    Book aBook = new Book();
    
    aBook.Title = "";
    Console.WriteLine(aBook.Title == "N/A");
    Console.WriteLine();
    
    aBook.Title = "The Hobbit";
    Console.WriteLine(aBook.Title == "The Hobbit");
    Console.WriteLine();
    
    aBook.Month = 100;
    Console.WriteLine(aBook.Month == 0);
    
    aBook.Month = 7;
    Console.WriteLine(aBook.Month == 7);
  
    

    
  }  // EOMC
} // EOMM

class Book {
  string title;
  public string Title {
    get { return title; }
    set { title = value != "" ? value : "N/A";
          Console.WriteLine(title);
    }
  }
  
  int month;
  public int Month {
    get { return month; }
    set { month = (1 <= value) && (value <= 12) ? value : 0;}
  }
  
}


