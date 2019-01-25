using System;

namespace Human2
{
    class Human
{
    // Fields for Human
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    private int health;
     
    // add a public "getter" property to access health
    public int HumanHealth{
        get {return health;}
    }
     
    // Add a constructor that takes a value to set Name, and set the remaining fields to default values
    public Human(string myName){
        Name= myName;
        Strength= 5;
        Intelligence= 5;
        Dexterity= 5;
        health= 100;

    }
    // Add a constructor to assign custom values to all fields
    public Human(string myName, int myStrength, int myIntell, int myDext, int myHealth ){
        Name= myName;
        Strength= myStrength;
        Intelligence= myIntell;
        Dexterity= myDext;
        health= myHealth;
    }
    // Build Attack method
    public int Attack(Human target){
        //target.health= target.HumanHealth-5;
        target.health= target.health- Strength*5;
        return target.HumanHealth;
    }

}
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Human A= new Human("A");
            Human B= new Human("B");
            A.Attack(B);
            Console.WriteLine(B.HumanHealth);
            //Console.WriteLine(A.HumanHealth);
        }
    }
}
