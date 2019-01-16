using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Birds:  Animals
    {
        // Inheritance
        public override string bloodType { get; set; } = "warm-blooded";
        public override string exterior { get; set; } = "feathers";
        public override string reproduction { get; set; } = "eggs";
        public override bool teeth { get; set; } = false;
        public override bool spine { get; set; } = true;

        // Pass Down
        public abstract bool beak { get; set; }
        public void EyeMovement()
        {
            Console.WriteLine("I cannot move my eyes! I have to turn my head to see my environment!");
        }
        public abstract bool flight { get; set; }

    }
}
