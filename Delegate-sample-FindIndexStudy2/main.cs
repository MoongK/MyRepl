using System;

class MainClass {
  
  delegate bool Condition(int i);
  
  static bool exist(int i){
    return i == 7;
  }
  
  public static void Main (string[] args) {
    int[] scores = new int[] {1,2,3,5,10,7,8};  // Length : 7
    
    int result;
    result = FindIndex(scores, (a) => (a == 7));    // 함수 호출 시 매개변수에 함수 자체를 매개변수로 줄 수 있다.

    Console.WriteLine(result == 5);
    Console.WriteLine(FindIndex(scores, exist) == 5);
  }
  
  static int FindIndex(int[] list, Condition callback) {
    for (int i=0;i<list.Length;i++){
      if (callback(list[i]))
        return i;
    }
      return -1;
  }
}