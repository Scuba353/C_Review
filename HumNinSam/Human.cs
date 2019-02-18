using System;

namespace HumNinSam
{
    class Human{
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        //public int health;
        //if use protected/private the target.heatlh isnt accessable in the Wizard attack method.
        protected int _health;
         
        public int Health{
            get { return _health; }
            //set method
            set {_health= value;}
        }
         
        public Human(string name){
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            _health = 100;
        }
         
        public Human(string name, int str, int intel, int dex, int hp){
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            _health = hp;
        }
         
        // Build Attack method
        public virtual int Attack(Human target){
            int dmg = Strength * 3;
            // target._health -= dmg;
            target.Health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.Health;
        }
    //   public void getAttacked(int damage){
    //         if(damage>this.health){
    //               this.health = 0;
    //         }else{
    //               this.health-=damage;
    //         }
    //     }

    }//end Human Class
}
