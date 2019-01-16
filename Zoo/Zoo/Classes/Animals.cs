using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public abstract class Animals: IEat, IReproduce
    {
        public abstract string bloodType { get; set; }
        public abstract string exterior { get; set; }
        public abstract string reproduction { get; set; }
        public virtual string name { get; set; } = "I have no Name";
        public virtual string BloodType(string bloodType)
        {
            return $"I am {bloodType}!";
        }

        public abstract bool teeth { get; set; }
        public abstract bool spine { get; set; }

        public string Reproduce(string repoduction)
        {
            return $"I have kids by {repoduction}!";
        }
        public string Eat(string[] diet)
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
