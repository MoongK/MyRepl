using System;

class MainClass {
  public static void Main (string[] args) {
    
    LinkedList list = new LinkedList();
    Console.WriteLine(list.AddLast("one"));
    Console.WriteLine(list.AddLast("two"));
    Console.WriteLine(list.AddLast("three"));
    
    Console.WriteLine(list.Count == 3);
    Console.WriteLine(list.Stringify());
    list.DelFirst();
    Console.WriteLine(list.Count == 2);
    Console.WriteLine(list.Stringify());
    list.AddFirst("one");
    Console.WriteLine(list.Count == 3);
    Console.WriteLine(list.Stringify());
    list.AddFirst("zero");
    Console.WriteLine(list.Count == 4);
    Console.WriteLine(list.Stringify());
    list.DelFirst();
    Console.WriteLine(list.Stringify());
    list.DelFirst();
    list.DelFirst();
    list.DelFirst();
    list.DelFirst(); // Empty List.
    list.AddFirst("one");
    Console.WriteLine(list.Count == 1);
    
    
    
  }
}

class Node {
  public string data;   //데이터 부분
  public Node next;     // 다음 노드를 가르키는 부분.
  
}

class LinkedList {
  Node head;
  Node tail;
  
  public int Count { get; private set; }
  
  public LinkedList() {
    head = tail = null;
    Count = 0;
  }
  
  public string AddLast(string obj){
    Node newNode = new Node();
    newNode.data = obj;
    newNode.next = null;
    
    if(tail == null){
      head = tail = newNode;
    }else {
      tail.next = newNode;
      tail = newNode;
    }
    Count++;
    return tail.data;
  }
  
  public string Stringify() {
    Node current = head;
    string s = "";
    
    while(current != null) {
      s+= current.data;
      current = current.next;
    }
    return s;
  }
  
  public void DelFirst(){
    if(head==null)
      Console.WriteLine("Empty List.");
    else{
      if(head == tail){ // 노드가 하나밖에 없을 때
        head.data = null;
        head = tail = null;
      }
      else{
        head.data = null;
        head = head.next;
      }
      Count--;
    }
  }

  public void AddFirst(string obj){
    Node newNode = new Node();
    newNode.data = obj;
    if(head == null){
      head = tail = newNode;
      head.next = null;
    }
    else{
      newNode.next = head;
      head = newNode;
    }
    Count++;

  }
  
}