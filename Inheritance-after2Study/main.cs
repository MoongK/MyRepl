using System;

class MainClass {
  public static void Main (string[] args) {
    
    Novel nov = new Novel();
    Magazine mag = new Magazine();
    
    nov.title = "The Hobbit";
    nov.genre = "Fantasy";
    nov.writer = "J.R.R.Tolkien";
    
    mag.title = "Hello Computer";
    mag.genre = "Computer";
    mag.releaseDay = 1;
    
    nov.printNov();
    Console.WriteLine("========");
    mag.printMag();
    
  }
}


class Book {
  public string title;
  public string genre;
  
  public void printBook() {
    Console.WriteLine("Title : " + this.title);
    Console.WriteLine("Genre : " + this.genre);
  }
}

class Novel : Book {
  public string writer;
  public void printNov() {
    printBook();
    Console.WriteLine("Writer : " + writer);
  }
}

class Magazine : Book {
  public int releaseDay;
  public void printMag(){
    printBook();
    Console.WriteLine("releaseDay : " + releaseDay);
  }
}

