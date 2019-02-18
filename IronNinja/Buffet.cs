using System;
using System.Collections.Generic;

namespace IronNinja{


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
}