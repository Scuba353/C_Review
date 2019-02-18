using System;

namespace HumNinSam{
class Samurai : Human{
        public Samurai(string name): base(name){
            _health = 200;
        }
        public override int Attack(Human target){
            base.Attack(target);
            if(target.Health<50){
                target.Health=0;
            }
            return this._health;
        }

        public void Meditate(){
            if(_health<200){
                _health=200;
            }
        }
    }//end Samurai class
}