using System;

namespace HumNinSam
{
    class Program
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

        class Samurai : Human{
            public Samurai(string name): base(name){
                _health = 200;
            }
            public override int Attack(Human target){
                base.Attack(target);
                if(target.Health<50){
                    target.Health=0;
                }
                return this._health;
            }

            public void Meditate(){
                if(_health<200){
                    _health=200;
                }
            }
        }//end Samurai class


    
        static void Main(string[] args){
            Console.WriteLine("Hello World!");
        }


    }//end Program class 
}//end Namespace
