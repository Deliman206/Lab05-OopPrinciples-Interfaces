using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Cats : Mammals
    {
        // Inheritance
        public override bool fur { get; set; } = true;
        public override string movement()
        {
            return "I can run and climb";
        }

        // Pass Down
        public string[] diet = { "mice", "deer", "insects" };
        public int feet = 4;
    }
}
