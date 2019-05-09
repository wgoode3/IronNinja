using System;
using System.Collections.Generic;

namespace IronNinja
{
    class SweetTooth: Ninja
    {

        public SweetTooth(string name) : base(name, 1500)
        {}

        public override void Consume(IConsumable item)
        {
            if(item.IsSweet)
                item.Calories += 50;

            base.Consume(item);
        }
    }
}
