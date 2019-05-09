namespace IronNinja
{
    class Drink : IConsumable
    {
        public string Name {get;set;}
        public int Calories {get;set;}
        public bool IsSpicy {get;set;}
        public bool IsSweet {get;set;}
        
        // Add a constructor method
        public Drink(string Name, int Cal, bool Spicy)
        {
            this.Name = Name;
            this.Calories = Cal;
            this.IsSpicy = Spicy;
            this.IsSweet = true;
        }

        // Implement a GetInfo Method
        public string GetInfo()
        {
            string description = $"You see a ";
            if(this.IsSpicy)
                description += "spicy, ";
            return description += $"sweet {this.Name} ({this.Calories})";
        }

    }   
}

