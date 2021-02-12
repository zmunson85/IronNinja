namespace IronNinja
{
    class Drink : IConsumable
    {
        public string Name { get; set; }
        public int Calories { get; set; }
        public bool IsSpicy { get; set; }
        public bool IsSweet { get; set; }

        // Add Get Method
        public Drink(string name, int calories, bool isSpicy)
        {
            Name = name;
            Calories = calories;
            IsSpicy = isSpicy;
            IsSweet = true;
        }
        public string GetInfo()
        {
            return $"{Name} (Bottoms Up!).  Calories: {Calories}.  Spicy?: {IsSpicy}, Sweet?: {IsSweet}";
        }
    }
}