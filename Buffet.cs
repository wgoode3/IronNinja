using System;
using System.Collections.Generic;

namespace IronNinja
{
    class Buffet
    {
        public List<IConsumable> Menu;
        public Random rand;
        
        //constructor
        public Buffet()
        {
            this.rand = new Random();
            this.Menu = new List<IConsumable>()
            {
                new Food("Sushi", 300, true, false),
                new Food("Cheeseburger", 650, false, false),
                new Food("Turkey Sub", 600, false, false),
                new Food("Pecan Pie", 800, false, true),
                new Food("Sweet and Sour Chicken", 750, true, true),
                new Food("Perogi", 500, false, false),
                new Food("Beef Dumpling", 600, true, false),
                new Drink("Fireball", 400, true),
                new Drink("Coke", 300, false),
                new Drink("Ice Tea", 200, false)
            };
        }
        
        public IConsumable Serve()
        {
            int menuLength = this.Menu.Count;
            int randInteger = this.rand.Next(0, menuLength);
            return this.Menu[randInteger];
        }
    }
}
