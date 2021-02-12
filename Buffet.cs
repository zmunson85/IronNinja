using System;
using System.Collections.Generic;

namespace IronNinja
{
    class Buffet
    {
        public List<IConsumable> Menu;
        public Buffet()
        {
            Menu = new List<IConsumable>()
            {
                new Food("ChickenNRice", 1000, true, false),
                new Food("Nachos", 450, true, false),
                new Food("KaleChips", 80, false, false),
                new Food("Tacos", 600, true, false),
                new Food("SteakNEggs", 900, false, false),
                new Drink("TurkeySandwich", 300, false),
                new Drink("Shot Of Whiskey", 200, false),
                new Drink("Orange Juice", 30, true)
            };
        }
        public IConsumable Serve()
        {
            Random r = new Random();
            return Menu[r.Next(Menu.Count)];
        }

    }
}