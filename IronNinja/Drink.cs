using System;

namespace IronNinja{

    class Drink : IConsumable
    {
        public string Name {get;set;}
        public int Calories {get;set;}
        public bool IsSpicy {get;set;}
        public bool IsSweet {get;set;}

        // Implement a GetInfo Method
        public string GetInfo(){
            return $"{Name} (Drink). Calories: {Calories}. Spicy? {IsSpicy}. Sweet? {IsSweet}, Drinks always have sugar in them!";
        }
    
        // Add a constructor method
        public Drink(string item, int cal, bool spice){
                Name= item;
                Calories= cal;
                IsSpicy= spice;
                IsSweet= true;
            }
        //Make sure drink objects are always sweet
    }  
}