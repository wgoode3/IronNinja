using System;
using System.Collections.Generic;

namespace IronNinja
{
    class SpiceHound: Ninja
    {

        public SpiceHound(string name) : base(name, 1200)
        {}

        public override void Consume(IConsumable item)
        {
            if(item.IsSpicy)
                item.Calories -= 50;

            base.Consume(item);
        }
    }
}
