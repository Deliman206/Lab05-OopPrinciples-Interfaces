using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Arthopods : Animals
    {
        // Inheritance
        public override string bloodType { get; set; } = "cold-blooded";
        public override string exterior { get; set; } = "exo-skeleton";
        public override string reproduction { get; set; } = "eggs";
        public override bool teeth { get; set; } = false;
        public override bool spine { get; set; } = false;

        // Pass Down
        public virtual string Legs(int legCount)
        {
            return $"I have {legCount} legs";
        }
        public virtual string segmentedBody { get; set; } = "I have a segmented body";
    }
}
