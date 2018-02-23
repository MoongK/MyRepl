using System;

class MainClass {
  public static void Main (string[] args) {
    Enemy monster = new Enemy();
    Player user = new Player();
    
    Console.WriteLine("Enemys h.p : "+monster.hp);
    Console.WriteLine("Players h.p : "+user.hp);
    
    monster.TakeDamage(65);
    user.TakeDamage(100);
    
    user.TakeDamage(50);
    
    Console.WriteLine("Enemys h.p : "+monster.hp);
    Console.WriteLine("Players h.p : "+user.hp);
    
    LivingEntity[] liver = new LivingEntity[2];
    
    liver[0] = new Enemy();
    liver[1] = new Player();
    
    foreach(LivingEntity liv in liver){
      liv.TakeDamage(30);
    }
    
    
  }
}



class LivingEntity{
  public int hp = 100;
  public string name;
  
  public virtual void TakeDamage(int damage) {
    this.hp -= damage;     
    Console.WriteLine("Hp : " + hp);
  }
}


class Enemy : LivingEntity {
  public override void TakeDamage(int damage) {
    if(hp <= damage){
      hp = 0;
      Console.WriteLine("Dead effect!");
      Console.WriteLine("Add exp to Player.");
    }
    else
      base.TakeDamage(damage);
      
  }
}

class Player : LivingEntity {
  public override void TakeDamage(int damage) {
    if(hp <= damage) {
      hp = 0;
      Console.WriteLine("Player was Dead..But revived!");
      hp = 100;
      Console.WriteLine("Hp : " + hp);
    }
    else
      base.TakeDamage(damage);
  }
}

class None {

  
}