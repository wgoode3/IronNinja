using System;
using System.Collections.Generic;

namespace IronNinja
{
    abstract class Ninja
    {
        private int calorieIntake;
        public int calorieLimit;
        public List<IConsumable> Stomach;
        public string name;

        // add a constructor
        public Ninja(string name, int limit)
        {
            this.calorieLimit = limit;
            this.calorieIntake = 0;
            this.Stomach = new List<IConsumable>();
            this.name = name;
        }

        // add a public "getter" property called "IsFull"
        public bool IsFull {
            get { return calorieIntake >= this.calorieLimit; }
        }

        // build out the Consume method
        public virtual void Consume(IConsumable item)
        {
            Console.WriteLine(item.GetInfo());
            if(this.IsFull)
            {
                Console.WriteLine($"{this.name} is too full for {item.Name}");
                Console.WriteLine($"{this.name} has consumed {this.calorieIntake} KCal today");
                return;
            }
            this.calorieIntake += item.Calories;
            this.Stomach.Add(item);
            if(item is Food)
            {
                Console.WriteLine($"{this.name} just ate a {item.Name}");
            }
            else
            {
                Console.WriteLine($"{this.name} just drank a {item.Name}");   
            }
        }
    }

}