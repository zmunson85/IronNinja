using System;

namespace IronNinja
{
    class SweetTooth : Ninja
    {
        // overide isfull
        public override bool IsFull
        {
            get { return calorieIntake > 1800; }
        }
        public override void Consume(IConsumable item)
        {
            // provide override for Consume
            if (IsFull)
            {
                Console.WriteLine("Too full, won't do it.");
                return;
            }
            int newCalories = (item.IsSweet) ? item.Calories + 10 : item.Calories;
            calorieIntake += newCalories;
            FoodHistory.Add(item);
            item.GetInfo();
        }
    }
}