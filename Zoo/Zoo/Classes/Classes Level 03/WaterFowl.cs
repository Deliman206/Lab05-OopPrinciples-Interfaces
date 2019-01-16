using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class WaterFowl: Birds
    {
        // Inheritance
        public override bool beak { get; set; } = false;
        public override bool flight { get; set; } = true;

        // Pass Down
        public string[] diet = { "fish eggs", "fish", "worms", "mollusk" };
        public int feet = 2;
    }
}
