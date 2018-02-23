using System;

class MainClass {
  public static void Main (string[] args) {
    int[] nums = {1, 2, 3, 4};
    string std = "hello";
    string[] names = { "hi", "ho", "he" };
    
    foreach (int i in nums){
      Console.WriteLine(i);
    }
  
    Console.WriteLine("============");
    
    for(int i=0;i<nums.Length;i++){
      Console.WriteLine(nums[i]);
    }
    
    foreach(string i in names){
      Console.WriteLine(i);
     }
    
    for(int i=0;i<std.Length;i++){
      Console.WriteLine(std[i]);
    }
  
    
  }
}