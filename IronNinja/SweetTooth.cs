using System;
using System.Collections.Generic;

namespace IronNinja{

    class SweetTooth: Ninja
    {
        public override bool IsFull(){
            if(calorieIntake < 1500){
                return false;
            } 
            else {
                return true;
            }
        }

        public override void Eat(IConsumable item){
            if(IsFull() == true){
                Console.WriteLine("Your Ninja is a fatty and can't eat anymore!");
            }
            else{
                calorieIntake+= item.Calories;
                if(item.IsSweet == true){
                    calorieIntake += 10;  
                }
                FoodHistory.Add(item);
                item.GetInfo();
            }
        }

    }//End SweetTooth Class
}