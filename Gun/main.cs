using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("ax^2 + bx + c = 0 ---> Start!!");
  //===================================변수 선언 시작==============================
    Console.Write("Input a : ");            // -----a,b,c값 입력 받기 시작
    string s_a= Console.ReadLine();
    Console.Write("Input b : ");
    string s_b= Console.ReadLine();
    Console.Write("Input c : ");
    string s_c= Console.ReadLine();        //  -----a,b,c값 입력 받기 끝
    
    double a = Convert.ToInt32(s_a); 
    double b = Convert.ToInt32(s_b); 
    double c = Convert.ToInt32(s_c); 
    
    double pan = Math.Pow(b,2.0)-(4*a*c);    // 판별식
    
    double p_gun;           //plus 근
    double m_gun;           // minus 근
    
    double plus_result;   // plus 근을 넣었을 때의 방정식 결과변수 선언
    double minus_result;  // minus 근을 넣었을 때의 방정식 결과변수 선언
    
  //  =================================변수 선언 끝==================================
    
  // ==========================계산=================================
    if(a==0){                                             // 1번 if : a가 0일 때 계산 불가능.
        Console.WriteLine("a can't be '0'.");
            }
    else{                                                 // 1번 if와 짝 : a가 0이 아닐 때 계산 시작.
        Console.WriteLine("pan = " + pan);
        
        if(pan >=0 ){                                    // 2번 if : 판별식이 0이상일 때 계산
      
          p_gun = (-b+Math.Sqrt(pan))/(2*a);
          m_gun = (-b-Math.Sqrt(pan))/(2*a);
      
          if(pan == 0){                                 // 3번 if : 판별식이 0일 때 중근이므로 p_gun을 사용.
            Console.WriteLine("p_gun = " + p_gun);    // 중근(p_gun) 출력.
            
            plus_result = a*Math.Pow(p_gun,2.0)+b*p_gun+c; // p_gun을 넣었을 때 plus_result 값을 지정.
            Console.WriteLine("ax^2+bx+c = " + plus_result); // plus_result == 0 인지 출력(아니면 틀림)
                          }
                          
          else if(pan > 0){                                         // 3번 if와 짝 : 판별식이 0보다 클 때.(두 근을 가진 계산)
            Console.WriteLine("p_gun = " + p_gun);    // p_gun 출력.
            Console.WriteLine("m_gun = " + m_gun);    // m_gun 출력.
            
            plus_result = a*Math.Pow(p_gun,2.0)+b*p_gun+c;    //plus_result 값 지정.
            minus_result = a*Math.Pow(m_gun,2.0)+b*m_gun+c;   //minus_result 값 지정.
            
            Console.WriteLine("(p_gun) : ax^2+bx+c = " + plus_result);    // plus_result == 0인지 판별. 
            Console.WriteLine("(m_gun) : ax^2+bx+c = " + minus_result);   // minus_result == 0인지 판별.
              }
              
                    }
    
        else{                                           // 2번 if와 짝 : 판별식이 0보다 작으면 허수이므로 계산 불가능.
            Console.WriteLine("===b*b must be bigger than 4ac.===");
            }
        }
  // ===============================계산 끝===============================
  }
}