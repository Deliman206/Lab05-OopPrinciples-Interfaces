using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class SiberianTiger: Cats
    {
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
