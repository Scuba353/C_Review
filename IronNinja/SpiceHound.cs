using System;
using System.Collections.Generic;

namespace IronNinja{

    class SpiceHound: Ninja
    {
        public override bool IsFull(){
            if(calorieIntake < 1200){
                return false;
            } 
            else {
                return true;
            }
        }

        public override void Eat(IConsumable item){
            if(IsFull() == true){
                Console.WriteLine("Your Ninja is too Spicy and can't eat anymore!");
            }
            else{
                calorieIntake+= item.Calories;
                if(item.IsSpicy == true){
                    calorieIntake -= 5;  
                }
                FoodHistory.Add(item);
                Console.WriteLine(item.GetInfo());
            }
        }

    }//End SweetTooth Class
}