using System;

class MainClass {
  public static void Main (string[] args) {
    
    Scope sc = new Scope();
    sc.printZoom();
    
    int n = 1;
    {
      int x = 10;
      {
        int z = 2;
        n = z;
      }
    }
    
    
  } // End of MainMethod
} // End of MainClass

class Scope {
  int zoom = 1;
  public void printZoom() {
    int  zoom = 2;
    
    Console.WriteLine(zoom + ", " + this.zoom);
  }
}