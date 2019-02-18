using System;

namespace HumNinSam{
     class Ninja : Human{
        public Ninja(string name): base(name){
            Dexterity = 175;
        }
        public override int Attack(Human target){
            Random rand= new Random();
            var addAttack= rand.Next(100);
            if(addAttack<=20){
                int dmg = Dexterity * 5 +10;
                target.Health -= dmg;
                Console.WriteLine($"{this.Name} attacked {target.Name} for {dmg} damage!");
            }
            else{
                int dmg = Dexterity * 5;
                target.Health -= dmg;
                Console.WriteLine($"{this.Name} attacked {target.Name} for {dmg} damage!");
            }
            return this._health;
        }

        public void Steal(Human victim){
            victim.Health-=5;
            this._health+=5;
        }
    }//end Ninja class
}