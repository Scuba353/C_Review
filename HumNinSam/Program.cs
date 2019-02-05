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
            public int health;
            //if use protected/private the target.heatlh isnt accessable in the Wizard attack method.
            //protected int health;
             
            public int Health{
                get { return health; }
            }
             
            public Human(string name){
                Name = name;
                Strength = 3;
                Intelligence = 3;
                Dexterity = 3;
                health = 100;
            }
             
            public Human(string name, int str, int intel, int dex, int hp){
                Name = name;
                Strength = str;
                Intelligence = intel;
                Dexterity = dex;
                health = hp;
            }
             
            // Build Attack method
            public virtual int Attack(Human target){
                int dmg = Strength * 3;
                target.health -= dmg;
                Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
                return target.health;
            }
        }//end Human Class

        class Wizard : Human{
            public Wizard(string name): base(name){
                Intelligence = 25;
                health = 50;
            }

            public override int Attack(Human target){
                int dmg = Intelligence * 5;
                //Human health isnt available if using the protected or privage accessors
                target.health -= dmg;
                health += dmg;
                Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
                return this.health;
            }

        }//end Wizard class
        class Ninja : Human{
            public Ninja(string name): base(name){
                Dexterity = 175;
            }
        }//end Ninja class

        class Samurai : Human{
            public Samurai(string name): base(name){
                health = 200;
            }
        }//end Samurai class


    
        static void Main(string[] args){
            Console.WriteLine("Hello World!");
        }


    }//end Program class 
}//end Namespace
