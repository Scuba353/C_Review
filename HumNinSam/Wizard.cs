using System;

namespace HumNinSam{
    class Wizard : Human{
        public Wizard(string name): base(name){
            Intelligence = 25;
            _health = 50;
        }

        //Human target will allow an attack of Human or any decendents.
        public override int Attack(Human target){
            int dmg = Intelligence * 5;
            //Human _health isnt available if using the protected or privage accessors
            //Uppercase Health will access the set method and change the value here. 
            //Or you could use a seperate method to set the value as Brianna had sent to me
            target.Health -= dmg;
            this._health += dmg;
            Console.WriteLine($"{this.Name} attacked {target.Name} for {dmg} damage!");
            return this._health;
        }

        public void Heal(Human hurt){
            hurt.Health += hurt.Intelligence*10;
        }
    }//end Wizard class
}