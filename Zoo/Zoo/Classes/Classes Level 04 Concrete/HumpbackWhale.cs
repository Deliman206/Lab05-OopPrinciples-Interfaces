using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class HumpbackWhale : Whales
    {
        public string Exterior(string exterior, string segmentedBody)
        {
            return $"I have a {exterior} body! My body has {segmentedBody}";
        }
        public string Reproduction(string repoduction)
        {
            return $"I have kids by {repoduction}!";
        }
        public string Diet(string[] diet)
        {
            string foods = "";
            foreach (string food in diet)
            {
                foods += $"{food} ";
            }
            return $"I eat {foods}.";
        }
    }
}
