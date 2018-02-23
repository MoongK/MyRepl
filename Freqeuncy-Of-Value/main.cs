using System;
using System.Collections;

class MainClass {
  public static void Main (string[] args) {
  
  Ready inputer = new Ready();
  inputer.action();
  
  Starter game = new Starter(inputer.array);

  } // EoMm
} // EoMc





class Ready { // Ready ==============
  public int[] array;
  
  public void action(){
    
  ArrayList l_ary = new ArrayList();
  
  for(int i=0;;i++)
  {
    Console.Write("Input Element : ");
    string s_e = Console.ReadLine();
    if(s_e=="-")
    {
    break;
    }
    else{
    int i_e = Convert.ToInt32(s_e);
    l_ary.Add(i_e);
        }
  }
  
  array = new int[l_ary.Count];
  
  for(int i=0;i<l_ary.Count;i++){
    array[i] = (int)l_ary[i];
  }
  
  Console.WriteLine("Done!");
  Console.Write("array : { ");
  
  for(int i=0;i<array.Length;i++)
  {
    Console.Write(array[i]+" ");  
  }
  
  Console.WriteLine("}");
  }
  
  
}  // End of Ready ================





 

class Starter {  // Starter ===================================
  
  public int[] ary; //= {1,2,2,3,3,3,3,4,4,4,4};
  public int[] ck_ary; // ck_ary = new int[ck_size(ary)];
  public int[] ck_arycount; // ck_arycount = new int[ck_size(ary)];
  
  // ===================================생성자===
  public Starter(int[] start_ary){
    ary = start_ary;
    gaming();
  }
  
  public Starter() {
    Console.WriteLine("Input a parameter..");
    // ary = new int[5];
    // gaming();
  }
  // ===================================생성자===
  
  
  public void gaming(){ // ============= 총 정리.
    
    
    ck_size(ary);
    ck_ary_member(ck_ary);
    ck_arycount_member(ck_ary, ck_arycount);
    ck_countmax();
    
    // ck_size(ary);
    // ck_ary_member(ck_ary);
    // ck_arycount_member(ck_ary, ck_arycount);
    // ck_countmax();
    
    
  }
  
  
  public int ck_size(int[] x){ // ============ ck_size 설정
    int ck_size=0;
    Console.Write("ck_size : ");
    for(int i=0;i<x.Length;i++){
      for(int j=0;j<x.Length;j++){
        if(j==i){
          ++ck_size;
          break;
        }else if(j<i){
          if(ary[i]==ary[j]){
           break;
          }
        }
      }
    }
     ck_ary = new int[ck_size];
     ck_arycount = new int[ck_size];
      
    Console.WriteLine(ck_size);
    return ck_size;
  } // End of ck_siezMethod    // ===================
  
  
  public void ck_ary_member(int[] x){ // ======= ck_ary(ary 인수의 종류를 저장한 배열) 설정
     // x = ck_ary { , , }
     Console.Write("ck_ary : { ");
     
    int ck_ary_index = 0;
    
    for(int i=0;i<ary.Length;i++){
      for(int j=0;j<ary.Length;j++){
       if(j<i && ary[i]==ary[j]){
         break;
       }else if(i==j){
         x[ck_ary_index] = ary[i];
         ++ck_ary_index;
       }
    }
  }
    for(int i=0;i<x.Length;i++){
      Console.Write(x[i]+" ");
    }
    Console.WriteLine("}");
  } // End of ck_memberMethod  // ======================
  
  public void ck_arycount_member(int[] x, int[] y){ // ======== ck_arycount(ck_ary 인수별 개수를 저장한 배열) 설정
    // x = ck_ary;
    // y = ck_arycount;
    int ck_count;
    
    Console.Write("ck_arycount : { ");
    
    for(int i=0;i<x.Length;i++){
      ck_count=0;
      for(int j=0;j<ary.Length;j++){
        if(x[i]==ary[j])
        ++ck_count;
      }
      y[i] = ck_count;
    }
    for(int i=0;i<y.Length;i++){
      Console.Write(y[i]+" ");
    }
    Console.WriteLine("}");
  } // End of ck_arycount_member ============================
  
  public void ck_countmax(){ // ======================ck_countmax(ck_arycount(각 숫자별 개수)의 값 중 가장 큰 값) 설정
    int ck_CountIndexmax = 0; // ck_arycount(각 숫자별 개수) 중 가장 큰 값을 가진 인수의 자리.
    int ck_countmax; // ck_countmax(ck_arycount(각 숫자별 개수)의 값 중 가장 큰 값)
    int result = 0; // 최대 개수를 가진 인수는 몇 개? 
    
    for(int i=0;i<ck_arycount.Length;i++){
      if(ck_arycount[i]>ck_arycount[ck_CountIndexmax]){
        ck_CountIndexmax = i;
      }
    }
    ck_countmax = ck_arycount[ck_CountIndexmax];
    Console.WriteLine("ck_arycount's max value : "+ck_countmax);
    
    Console.Write("Max of ary Element : ");
    for(int i=0;i<ck_arycount.Length;i++){
      if(ck_arycount[i] == ck_countmax){
        Console.Write(ck_ary[i]+" ");
        ++result;
      }
    }
    Console.WriteLine(" ("+result+")");
    Console.WriteLine("How many times? : "+ck_countmax);
  } // End of ck_countmax  =============================================

} // ======================================== End of Starter