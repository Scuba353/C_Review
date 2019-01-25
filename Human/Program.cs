using System;

namespace Human
{
    class Human{
        public string Name;
        public int Strength;
        public int Dexterity;
        public int Intelegence;
        public int Health;

        public Human(string myname){
            Name= myname;
            Strength = 3;
            Dexterity = 3;
            Intelegence =3;
            Health =100;

        }
        public Human(string myname, int str, int dex, int intel, int heal){
            Name= myname;
            Strength = str;
            Dexterity = dex;
            Intelegence =intel;
            Health =heal;
        }

        public void Attack(Human victim){
            victim.Health= victim.Health- (this.Strength*5);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Human Joe= new Human("Joe");
            Human Bob= new Human("Bob");
            Human Sue= new Human("Sue");
            Human Ann= new Human("Ann", 1,3,4,100);
            Console.WriteLine("sues health is {0}", Sue.Health);
            Joe.Attack(Sue);
            Console.WriteLine("sues health is {0}", Sue.Health);
            Console.WriteLine("Joes health is {0}", Joe.Health);
            Console.WriteLine("Bob health is {0}", Bob.Health);
            Ann.Attack(Bob);
            Console.WriteLine("Ann  health is {0}", Ann.Health);
            Console.WriteLine("Bob health is {0}", Bob.Health);
        }
    }
}
