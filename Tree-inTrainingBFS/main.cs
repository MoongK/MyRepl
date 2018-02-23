using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {

  Tree tree = new Tree();
  TreeNode root = new TreeNode(1); TreeNode two = new TreeNode(2); TreeNode three = new TreeNode(3);
  TreeNode four = new TreeNode(4); TreeNode five = new TreeNode(5); TreeNode six = new TreeNode(6);
  TreeNode seven = new TreeNode(7); TreeNode eight = new TreeNode(8); TreeNode nine = new TreeNode(9);
  TreeNode ten = new TreeNode(10); TreeNode eleven = new TreeNode(11); TreeNode twelve = new TreeNode(12);

  root.AddChild(two); root.AddChild(three); root.AddChild(four);
  two.AddChild(five); two.AddChild(six); // three have no children
  four.AddChild(seven); four.AddChild(eight);
  five.AddChild(nine); five.AddChild(ten); // six have no Children
  seven.AddChild(eleven); seven.AddChild(twelve); // eight have no Children
  
  Console.WriteLine(tree.BFS(root,Console.WriteLine) == "1 2 3 4 5 6 7 8 9 10 11 12 ");
  Console.WriteLine(tree.BFS(root,Console.WriteLine));
  
  } // emm
} //emc

class Tree{
  
  public string BFS(TreeNode node, Action<int> action){
    string s = string.Empty;
    Queue<TreeNode> q = new Queue<TreeNode>();
    q.Enqueue(node);
    
    while(q.Count>0){
      TreeNode n = q.Dequeue();
      action(n.Name);
      s+=n.Name + " ";
      
      foreach(TreeNode c in n.Children){
        q.Enqueue(c);
      }
    }
      return s;
  }
  
  public string DFS(TreeNode node){
    string s = string.Empty;
    
    
    return s;
  }
}



class TreeNode {
  public int Name {get;set;}
  public List<TreeNode> Children;
  
  public TreeNode(int name) {
    this.Name = name;
    this.Children = new List<TreeNode>();
  }
  
  public void AddChild(TreeNode c) {
    this.Children.Add(c);
  }
}