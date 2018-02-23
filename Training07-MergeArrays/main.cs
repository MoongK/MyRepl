using System;

class MainClass {
  public static void Main (string[] args) {

  int[] ary01 = {1,2,3,4,5};
  int[] ary02 = {1,1,2,2,3,3,4,4};
  int[] final = MergeArraysT(ary01,ary02);
  Console.WriteLine(final.Stringify() == "1 1 1 2 2 2 3 3 3 4 4 4 5");
  
  int[] ary03 = {1,3,5,7,9};
  int[] ary04 = {2,4,6,8,10};
  int[] final2 = MergeArraysT(ary03,ary04);
  Console.WriteLine(final2.Stringify() == "1 2 3 4 5 6 7 8 9 10");
  
  int[] ary05 = {5,6,7,8,9};
  int[] ary06 = {1,2,3,4,5};
  int[] final3 = MergeArraysT(ary05,ary06);
  Console.WriteLine(final3.Stringify() == "1 2 3 4 5 5 6 7 8 9");
  
  int[] ary07 = {1,4,8,9};
  int[] ary08 = {2,3,5,6,7,10};
  int[] final4 = MergeArraysT(ary07,ary08);
  Console.WriteLine(final4.Stringify() == "1 2 3 4 5 6 7 8 9 10");
  
  int[] ary09 = {5,6,7,8,9};
  int[] ary10 = {1,4,10};
  int[] final5 = MergeArraysT(ary09,ary10);
  Console.WriteLine(final5.Stringify() == "1 4 5 6 7 8 9 10");
  
  int[] ary11 = {0,5,8,10};
  int[] ary12 = {0,0,0,1,4,5,6,7,8,9};
  int[] final6 = MergeArraysT(ary11,ary12);
  Console.WriteLine(final6.Stringify() == "0 0 0 0 1 4 5 5 6 7 8 8 9 10");
  
  
  

  } // emm
  static int[] MergeArraysT(int[] A, int[] B){
    int[] result = new int[A.Length+B.Length];
    
    int Aindex = 0, Bindex = 0;
    
    for(int i=0;i<result.Length;i++){
      
      if(Aindex==A.Length){
        result[i] = B[Bindex];
        Bindex++;
      }
      else if(Bindex==B.Length){
        result[i] = A[Aindex];
        Aindex++;
      }
      else{
        if(A[Aindex] < B[Bindex]){
          result[i] = A[Aindex];
          Aindex++;
        }
        else{
          result[i] = B[Bindex];
          Bindex++;
        }
      }
    }
       
    return result;
  } // MergeArraysT
  
  // static int[] MergeArraysM(int[] A, int[] B){   // My
    
  //   int[] result = new int[A.Length+B.Length];
  //   int Bindex = 0;
  //   int putt = 0;
    
  //   for(int i=0;i<A.Length;i++){ //  A배열 먼저 다 집어넣기.
  //     result[i] = A[i];
  //     putt++;
  //   } // 
    
  //   while(putt != result.Length){
  //     for(int i=0;i<putt;i++){
        
  //       if(B[Bindex]<=result[i]){
        
  //         for(int j=putt;j>=i+1;j--){
  //           result[j] = result[j-1];
  //         } // 당기기
          
  //         result[i] = B[Bindex];
  //         Bindex++;
  //         putt++;
  //         break;
  //       } // if
        
  //     if(i==putt-1 && B[Bindex] > result[i]){ // 높은 값을 못찾고 끝까지 왔을 시
  //       result[putt] = B[Bindex];
  //       putt++;
  //       Bindex++;
  //       break;
  //     } // if
  //     } // for
  //   } // while
    
  //   return result;
  // } // MergeArraysM (My)
} // emc

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