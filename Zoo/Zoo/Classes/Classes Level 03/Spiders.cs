using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Spiders: Arthopods
    {
        public override string segmentedBody { get; set; } = "Cephalothorax and Abdomen";

        public string[] diet = { "ants", "flies", "birds" };
        public int legCount = 8;
    }
}
