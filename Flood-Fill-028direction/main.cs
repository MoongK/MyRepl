using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
  
    int[][] field = new int[][] {
      new int[] {0, 0, 0, 0, 0, 0, 0},
      new int[] {0, 0, 1, 1, 1, 0, 0},
      new int[] {0, 0, 1, 0, 1, 0, 0},
      new int[] {0, 0, 1, 0, 1, 0, 0},
      new int[] {0, 0, 1, 0, 1, 0, 0},
      new int[] {0, 0, 1, 1, 1, 0, 0},
      new int[] {0, 0, 0, 0, 0, 0, 0}
    };
    FloodFill(field, 2, 3, 7);                       // a,b,c,d : 배열 a행 b번째의 c를 d로 바꾼다.
    // Console.WriteLine( field[0].Stringify() == "0 0 0 0 0 0 0" );
    // Console.WriteLine( field[1].Stringify() == "0 0 1 1 1 0 0" );
    // Console.WriteLine( field[2].Stringify() == "0 0 1 7 1 0 0" );
    // Console.WriteLine( field[3].Stringify() == "0 0 1 7 1 0 0" );
    // Console.WriteLine( field[4].Stringify() == "0 0 1 7 1 0 0" );
    // Console.WriteLine( field[5].Stringify() == "0 0 1 1 1 0 0" );
    // Console.WriteLine( field[6].Stringify() == "0 0 0 0 0 0 0" );
    
    Console.WriteLine( field[0].Stringify() );
    Console.WriteLine( field[1].Stringify() );
    Console.WriteLine( field[2].Stringify() );
    Console.WriteLine( field[3].Stringify() );
    Console.WriteLine( field[4].Stringify() );
    Console.WriteLine( field[5].Stringify() );
    Console.WriteLine( field[6].Stringify() );
    
    
    
    
  } // emm
  
  static void FloodFill(int[][] ary, int a, int b, int c){
    
    int[][] arrays = ary;
    
    Linking(arrays,a,b,c);
    
  }
  static void Linking(int[][] InputAry, int p1, int p2, int color){
    
    int[][] ary = InputAry;
    
    Indexer proto = new Indexer(p1,p2);
    Indexer up, down, left, right;
    Indexer upleft, upright, downleft, downright;
    
    if(p1 > 0 && ary[p1-1][p2] == color)
      { up = null; }
    else if(p1 > 0 && ary[p1][p2] == ary[p1-1][p2])
      { up = new Indexer(p1-1,p2); }                        // up index
    else
      { up = null; }
    
    if(p1 < ary.Length-1 && ary[p1+1][p2] == color)
      { down = null; }
    else if(p1 < ary.Length-1 && ary[p1][p2] == ary[p1+1][p2])
      { down = new Indexer(p1+1,p2); }                      // down index
    else
      { down = null; }
      
    if(p2 > 0 && ary[p1][p2-1] == color)
      { left = null; }
    else if(p2 > 0 && ary[p1][p2] == ary[p1][p2-1])
      { left = new Indexer(p1,p2-1); }                      // left index
    else
      { left = null; }
    
    if(p2 < ary[p1].Length-1 && ary[p1][p2+1] == color)
      { right = null; }
    else if(p2 < ary[p1].Length-1 && ary[p1][p2] == ary[p1][p2+1])
      { right = new Indexer(p1,p2+1); }                    // right index
    else
      { right = null; }
      
    if((p1 > 0 && p2 > 0) && (ary[p1-1][p2-1] == color))
      { upleft = null; }
    else if((p1 > 0 && p2 > 0) && (ary[p1][p2] == ary[p1-1][p2-1]))
      { upleft = new Indexer(p1-1,p2-1); }                        // upleft index
    else
      { upleft = null; }
    
    if((p1 > 0 && p2 < ary[p1].Length-1) && (ary[p1-1][p2+1] == color))
      { upright = null; }
    else if((p1 > 0 && p2 < ary[p1].Length-1) && (ary[p1][p2] == ary[p1-1][p2+1]))
      { upright = new Indexer(p1-1,p2+1); }                      // upright index
    else
      { upright = null; }
      
    if((p1 < ary.Length-1 && p2 > 0) && (ary[p1+1][p2-1] == color))
      { downleft = null; }
    else if((p1 < ary.Length-1 && p2 > 0) && (ary[p1][p2] == ary[p1+1][p2-1]))
      { downleft = new Indexer(p1+1,p2-1); }                      // downleft index
    else
      { downleft = null; }
    
    if((p1 < ary.Length-1 && p2 < ary[p1].Length-1) && (ary[p1+1][p2+1] == color))
      { downright = null; }
    else if((p1 < ary.Length-1 && p2 < ary[p1].Length-1) && ary[p1][p2] == ary[p1+1][p2+1])
      { downright = new Indexer(p1+1,p2+1); }                    // downright index
    else
      { downright = null; }
      
    
    
    ary[proto.x][proto.y] = color; // Painting
    
    
    List<Indexer> list = new List<Indexer> {up, down, left, right, upleft, upright, downleft, downright};
    foreach(Indexer i in list){
      if(i != null)
        Linking(ary,i.x,i.y,color);
    }
    
    
  } // Linking
  
} // emc

public class Indexer{
  public int x{get;set;}
  public int y{get;set;}
  
  public Indexer(int a, int b){
    x = a;
    y = b;
  }
}

public static class Exclass{
  
public static string Stringify<T>(this T[] ary){ // this 타입에다가 현재 함수를 집어 넣으라는 뜻
    
    string s = String.Empty;
    
    for(int i=0;i<ary.Length;i++){
      if(i==ary.Length-1)
        s += ary[i].ToString();
      else
        s += (ary[i].ToString()+" ");
    }
    return s;
  }
  
}