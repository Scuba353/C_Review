using System;
using System.Collections.Generic;

namespace IronNinja{
    abstract class Ninja{
        protected int calorieIntake;
        public List<IConsumable> FoodHistory;

        public Ninja(){
            calorieIntake=0;
            FoodHistory= new List<IConsumable>();
        }
        
        //child classes of Ninja will implement how they determing if they are full
        public abstract bool IsFull();
        
        //child classes of Ninja will implement how they determing what they consume
        public abstract void Eat(IConsumable item);
   
    }
}