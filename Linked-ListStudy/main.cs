using System;

class MainClass {
  public static void Main (string[] args) {
    
    LinkedList list = new LinkedList();
    
    
    Console.WriteLine(list.Count == 0);
    list.AddLast("one");
    Console.WriteLine(list.Count == 1);
    list.AddLast("two");
    Console.WriteLine(list.Count == 2);
    Console.WriteLine(list.Stringify() == "onetwo");
    list.AddLast("three");
    Console.WriteLine(list.Stringify() == "onetwothree");
    Console.WriteLine(list.Count == 3);
    
    // Console.WriteLine(list.RemoveFirst() == "one");
    // Console.WriteLine(list.Stringify() == "twothree");
    // Console.WriteLine(list.AddFirst());
    
  }
}

class Node {
  public string data;
  public Node next;
}  

class LinkedList {
  Node head;
  Node tail;
  
  public int Count { get; private set; }
  
  public LinkedList() {
    head = tail = null;
    Count = 0;
  }

  public void AddLast(string obj){
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
    
}