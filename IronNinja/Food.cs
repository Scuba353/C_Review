using System;
using System.Collections.Generic;

namespace IronNinja{
    class Food: IConsumable 
    {
        public string Name {get; set;}
        public int Calories{get; set;}
        // Foods can be Spicy and/or Sweet
        public bool IsSpicy{get; set;}
        public bool IsSweet{get; set;}
        public string GetInfo(){
            return $"{Name} (Food). Calories: {Calories}. Spicy? {IsSpicy}, Sweet? {IsSweet}";
        }

        public Food(string item, int cal, bool spice, bool sweet){
            Name= item;
            Calories= cal;
            IsSpicy= spice;
            IsSweet= sweet;
        }
    }
}