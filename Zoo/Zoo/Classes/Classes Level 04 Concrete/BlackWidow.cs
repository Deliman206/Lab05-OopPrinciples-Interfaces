using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class BlackWidow : Spiders
    {
        public string Legs(Spiders legCount)
        {
            return $"I have {legCount} legs!";
        }
        public string Exterior(string exterior, string segmentedBody)
        {
            return $"I have a {exterior} body! My body has {segmentedBody}";
        }
        public string Reproduction(Spiders repoduction)
        {
            return $"I have kids by {repoduction}!";
        }
    }
}
