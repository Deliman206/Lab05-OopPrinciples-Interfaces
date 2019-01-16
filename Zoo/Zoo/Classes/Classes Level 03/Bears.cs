using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Bears : Mammals
    {
        // Inheritance
        public override bool fur { get; set; } = true;
        public override string movement()
        {
            return "I can swim, run, and climb!";
        }

        // Pass down
        public string[] diet = { "berries", "fish", "insects" };
        public int feet = 4;
    }
}
