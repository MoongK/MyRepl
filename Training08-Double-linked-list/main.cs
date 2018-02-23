/*Double linked list
1. 기존의 linked list를 double linked list로 변경
2. 관련 함수 모두 수정 :  AddLast(), AddFirst(), RemoveFirst()
3. RemoveLast() 추가로 구현(제거된 값을 돌려주기)
4. 기존의 Count 속성 제거.(노드를 모두 순회해서 갯수를 알아내는 Count() 구현)*/


using System;

class MainClass {
  public static void Main (string[] args) {
    
    Link link = new Link();
    link.AddLast("one");
    Console.WriteLine(link.Head.Name == "one");
    Console.WriteLine(link.Tail.Name == "one");
    Console.WriteLine(link.Head.Prev == null);
    Console.WriteLine(link.Head.Next == null);
    link.AddLast("two");
    Console.WriteLine(link.Head.Name == "one");
    Console.WriteLine(link.Tail.Name == "two");
    Console.WriteLine(link.Head.Prev.Name == "two");
    Console.WriteLine(link.Head.Next.Name == "two");
    Console.WriteLine(link.Tail.Prev.Name == "one");
    Console.WriteLine(link.Tail.Next.Name == "one");
    link.AddFirst("zero");
    Console.WriteLine(link.Head.Name == "zero");
    Console.WriteLine(link.Tail.Name == "two");
    Console.WriteLine(link.Head.Prev.Name == "two");
    Console.WriteLine(link.Head.Next.Name == "one");
    Console.WriteLine(link.Tail.Prev.Name == "one");
    Console.WriteLine(link.Tail.Next.Name == "zero");
    link.AddLast("three");
    Console.WriteLine(link.Head.Name == "zero");
    Console.WriteLine(link.Tail.Name == "three");
    Console.WriteLine(link.Head.Prev.Name == "three");
    Console.WriteLine(link.Head.Next.Name == "one");
    Console.WriteLine(link.Tail.Prev.Name == "two");
    Console.WriteLine(link.Tail.Next.Name == "zero");
    // Check Current
    Console.WriteLine(link.Head.Next.Name == "one");
    Console.WriteLine(link.Tail.Next.Name == "zero");
    Console.WriteLine(link.Head.Prev.Prev.Name == "two");
    Console.WriteLine(link.Head.Next.Next.Name == "two");
    Console.WriteLine(link.Tail.Prev.Prev.Name == "one");
    Console.WriteLine(link.Tail.Next.Next.Name == "one");
    Console.WriteLine(link.Head.Next.Next.Next.Name == "three");
    link.RemoveFirst();
    Console.WriteLine(link.Head.Name == "one");
    Console.WriteLine(link.Tail.Name == "three");
    Console.WriteLine(link.Head.Prev.Name == "three");
    Console.WriteLine(link.Head.Next.Name == "two");
    Console.WriteLine(link.Tail.Prev.Name == "two");
    Console.WriteLine(link.Tail.Next.Name == "one");
    link.AddFirst("zero");
    link.RemoveLast();
    Console.WriteLine(link.Head.Name == "zero");
    Console.WriteLine(link.Tail.Name == "two");
    Console.WriteLine(link.Head.Prev.Name == "two");
    Console.WriteLine(link.Head.Next.Name == "one");
    Console.WriteLine(link.Tail.Prev.Name == "one");
    Console.WriteLine(link.Tail.Next.Name == "zero");
    Console.WriteLine(link.Tail.Next.Next.Name == "one");
    Console.WriteLine(link.Head.Prev.Prev.Name == "one");
    
    Console.WriteLine("Count : " + link.Count());
    
  } // emm
} // emc

class Link{
  public Node Head, Tail;
  public int count = 0;
  
  public void AddFirst(string Node_name) {
    Node newNode = new Node(Node_name);
    newNode.Name = Node_name;
    
    if(Head==null && Tail == null){
      Head = newNode;
      Tail = newNode;
      newNode.Prev = null;
      newNode.Next = null;
    }
    else{
      Head.Prev = newNode;
      newNode.Next = Head;
      Head = newNode;
      Head.Prev = Tail;
      Tail.Next = Head;
    }
  }
  
  public void AddLast(string Node_name){
    Node newNode = new Node(Node_name);
    newNode.Name = Node_name;
    
    if(Head==null && Tail == null){
      Head = newNode;
      Tail = newNode;
      newNode.Prev = null;
      newNode.Next = null;
    }
    
    else{
      Tail.Next = newNode;
      newNode.Prev = Tail;
      Tail = newNode;
      Tail.Next = Head;
      Head.Prev = Tail;
    }
  }
  
  public void RemoveFirst() {
    if(Head==null){
      Console.WriteLine("Null Node.");
    }
    else if(Head == Tail){
      Head.Name = null;
      Head = null;
      Tail = null;
    }
    else{
      Head.Name = null;
      Head = Head.Next;
      Head.Prev = Tail;
      Tail.Next = Head;
    }
  }
  
  public void RemoveLast() {
    if(Head==null){
      Console.WriteLine("Null Node.");
    }
    else if(Head == Tail){
      Head.Name = null;
      Head = null;
      Tail = null;
    }
    else{
      Tail.Name = null;
      Head.Prev = Tail.Prev;
      Tail.Next = null;
      Tail = Tail.Prev;
      Tail.Next = Head;
    }
    
  }
  
  public int Count() {
    if(Head == null)
      return count;
      
    else{
      Node checker = Head;
      while(checker != Tail){
        count++;
        checker = checker.Next;
      
      }
      if(checker == Tail)
          count++;
        
      return count;
    }
  }
} // Link

class Node {
  public string Name {get;set;}
  public Node Prev, Next;
  
  public Node(string name){
    Name = name;
  }
}


public static class Exclass{
  public static string Stringify<Link>(this Link ss){ 
    
    string s = String.Empty;
    Node checking;
    
    return s;
  }
}