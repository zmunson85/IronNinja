using System.Collections.Generic;

namespace IronNinja
{
    abstract class Ninja
    {
        protected int calorieIntake;
        public List<IConsumable> FoodHistory;
        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<IConsumable>();
        }
        public abstract bool IsFull { get; }
        public abstract void Consume(IConsumable item);
    }
}