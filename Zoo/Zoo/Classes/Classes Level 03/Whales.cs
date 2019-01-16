using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Whales: Mammals
    {
        // Inheritance
        public override bool fur { get; set; } = false;
        public override string movement()
        {
            return "I can swim!";
        }
        // Pass down
        public string[] diet = { "fish", "krill" };
        public int feet = 0;

    }
}
