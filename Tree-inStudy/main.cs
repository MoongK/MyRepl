using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    
    Tree tree = new Tree();   // BFS : 옆으로..    DFS : 밑으로.. <----- 이거 두개 이해하기
    TreeNode root = new TreeNode("root");
    TreeNode a = new TreeNode("a");
    TreeNode b = new TreeNode("b");
    TreeNode c = new TreeNode("c");
    TreeNode d = new TreeNode("d");
    TreeNode e = new TreeNode("e");
    TreeNode f = new TreeNode("f");
    TreeNode g = new TreeNode("g");
    TreeNode h = new TreeNode("h");
    TreeNode i = new TreeNode("i");
    
    root.AddChild(a); root.AddChild(b); root.AddChild(c);
    a.AddChild(d); a.AddChild(e);
    b.AddChild(f); b.AddChild(g);
    g.AddChild(h); g.AddChild(i);
    
    Console.WriteLine(tree.BFS(root, Console.WriteLine) == "root a b c d e f g h i ");
    Console.WriteLine(tree.IterativeDFS(root));
    Console.WriteLine(tree.RecursiveDFS(root));
    
    Console.WriteLine( root.Name + " "      +
                       tree.RecursiveDFS(a) +
                       tree.RecursiveDFS(b) +
                       tree.RecursiveDFS(c));
  } // emm
} //emc

class TreeNode {
  public string Name {get;set;}
  public List<TreeNode> children;
  
  public TreeNode(string name){
    this.Name = name;
    this.children = new List<TreeNode>();
  }
  
  public void AddChild(TreeNode n){
    children.Add(n);
  }
  
}

class Tree{
  public TreeNode Root {get;set;}   // <--- 용도?
  
  public string BFS(TreeNode node, Action<string> action) {
    string s = String.Empty;
    Queue<TreeNode> q = new Queue<TreeNode>();
    q.Enqueue(node);
    
    while(q.Count > 0) {
      Console.Write("Count : "+ q.Count+ " : ");
      TreeNode n = q.Dequeue();// Enqueue, Dequeue 할 때 그 값이 리턴된다.
      s += n.Name + " ";
      action(n.Name);
      
      foreach(var c in n.children)
        q.Enqueue(c);
    }
    
    return s;
  }
  
  public string IterativeDFS(TreeNode node) {
    string s = String.Empty;
    Stack<TreeNode> stack = new Stack<TreeNode>();
    stack.Push(node);
    
    while(stack.Count >0) {
      TreeNode n = stack.Pop();
      s += n.Name + " ";
      
      for(int i = n.children.Count-1; i>= 0; i--)
        stack.Push(n.children[i]);
    }
    return s;
  }
  
  public string RecursiveDFS(TreeNode node) {    // RecursiveDFS : 재귀함수 이용
    string s = node.Name + " ";
    foreach(var n in node.children)
      s += RecursiveDFS(n);
    return s;
  }
  
} // End of Tree class