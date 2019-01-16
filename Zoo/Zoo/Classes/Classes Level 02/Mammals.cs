using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Mammals : Animals
    {
        // Inheritance
        public override string bloodType { get; set; } = "warm-blooded";
        public override string exterior { get; set; } = "hair";
        public override string reproduction { get; set; } = "birth";
        public override bool teeth { get; set; } = true;
        public override bool spine { get; set; } = true;

        //Passing down
        public abstract bool fur { get; set; }
        public abstract string movement();
        public virtual string whatToEat(string food)
        {
            return $"I eat {food}!";
        }
    }
}
