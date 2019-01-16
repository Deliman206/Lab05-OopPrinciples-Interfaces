using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class Raptors: Birds
    {
        // Inheritance
        public override bool beak { get; set; } = true;
        public override bool flight { get; set; } = true;

        // Pass Down
        public string[] diet = { "mice", "fish", "reptiles", "amphibians" };
        public int feet = 2;
    }
}
