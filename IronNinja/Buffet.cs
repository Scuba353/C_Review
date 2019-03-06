using System;
using System.Collections.Generic;

namespace IronNinja{


    class Buffet{
        public List<IConsumable> Menu;
        
        public Buffet(){
            Menu= new List<IConsumable>(){
                new Food("Taco", 500, true, false),
                new Food("Icecream", 1000, false, true), 
                new Food("Pizza", 700, false, false), 
                new Food("Cheese-Its", 100, false, false), 
                new Food("Beer", 0, false, false), 
                new Food("Salad", 0, false, false), 
                new Food("Ramen", 5000, true, false),
                new Drink("Soda", 300, false),
                new Drink("Coffee", 50, false),
                new Drink("Shake", 1000, false),
            };
        }
    
        static Random rand= new Random();      
        public IConsumable Serve(){
            int randItem= rand.Next(0,10);
            //object fooditem= Menu[randItem];
            //return fooditem.Name;
            return Menu[randItem];
        }
    }
}