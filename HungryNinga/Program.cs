using System;
using System.Collections.Generic;

namespace HungryNinga
{
    class Program
    {
        class Food{
            public string Name;
            public int Calories;
            // Foods can be Spicy and/or Sweet
            public bool IsSpicy; 
            public bool IsSweet; 

            public Food(string item, int cal, bool spice, bool sweet){
                Name= item;
                Calories= cal;
                IsSpicy= spice;
                IsSweet= sweet;
            }
        }

        class Buffet{
            public List<Food> Menu;
            
            public Buffet(){
                Menu= new List<Food>(){
                    new Food("Taco", 500, true, false),
                    new Food("Icecream", 1000, false, true), 
                    new Food("Pizza", 700, false, false), 
                    new Food("Cheese Its", 100, false, false), 
                    new Food("Beer", 0, false, false), 
                    new Food("Salad", 0, false, false), 
                    new Food("Ramen", 5000, true, false)
                };
            }
        
            static Random rand= new Random();      
            public Food Serve(){
                int randItem= rand.Next(0,7);
                //object fooditem= Menu[randItem];
                //return fooditem.Name;
                return Menu[randItem];
            }
        }
            class Ninga{
                private int calorieIntake;
                public List<Food> FoodHistory;

                public Ninga(){
                    calorieIntake=0;
                    FoodHistory= new List<Food>();
                }
                public bool IsFull {
                    get {if(calorieIntake < 1200){return false;} else {return true;}}
                }

                public void Eat(Food item){
                    if(IsFull == false){
                        calorieIntake+= item.Calories;
                        FoodHistory.Add(item);
                        Console.WriteLine("You're ninga ate" + item.Name + "and it was considered spicey: " + item.IsSpicy + " and sweet:" +item.IsSweet + ".");
                    }
                    else{
                        Console.WriteLine("You're Ninga is a fatty and can't eat anymore food.");
                    }
                }

            }



        
        static void Main(string[] args)
        {
          
            Console.WriteLine("Hello World!");
            Ninga A= new Ninga();
            Buffet B= new Buffet();
            Console.WriteLine(A);
            Console.WriteLine(B);
            Food yums= B.Serve();
            A.Eat(yums);
            Console.WriteLine(A);
            Food yums2= B.Serve();
            A.Eat(yums2);
            Console.WriteLine(A);


        }
    }
}
