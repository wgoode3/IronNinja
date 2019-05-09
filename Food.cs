using System;

namespace IronNinja
{
    class Food : IConsumable
    {
        public string Name{set;get;}
        public int Calories{set;get;}
        public bool IsSpicy{set;get;}
        public bool IsSweet{set;get;}
        public Food(string Name, int Cal, bool Spicy, bool Sweet)
        {
            this.Name = Name;
            this.Calories = Cal;
            this.IsSpicy = Spicy;
            this.IsSweet = Sweet;
        }
        public string GetInfo()
        {
            string description = $"You see a ";
            if(this.IsSpicy)
                description += "spicy ";
            if(this.IsSweet)
                description += "sweet ";
            return description += this.Name + $" ({this.Calories})";
        }
    }
}