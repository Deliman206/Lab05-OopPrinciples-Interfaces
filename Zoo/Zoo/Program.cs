using System;
using Zoo.Classes;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            BlackWidow charlotte = new BlackWidow();
            charlotte.name = "charlotte";

            Eagle ernest = new Eagle();
            ernest.name = "ernest";

            GrizzlyBear willis = new GrizzlyBear();
            willis.name = "willis";

            HumpbackWhale karl = new HumpbackWhale();
            karl.name = "karl";

            Mallard cheryl = new Mallard();
            cheryl.name = "cheryl";

            SiberianTiger goliath = new SiberianTiger();
            goliath.name = "goliath";


            Console.WriteLine($"Helo my name is {goliath.name}");
            Console.WriteLine(goliath.Reproduction( goliath.reproduction));
            Console.WriteLine(goliath.Diet(goliath.diet));
            Console.WriteLine("\n");
            Console.WriteLine($"Helo my name is {cheryl.name}");
            Console.WriteLine(cheryl.Reproduction(cheryl.reproduction));
            Console.WriteLine(cheryl.Diet(cheryl.diet));
            Console.WriteLine("\n");
            Console.WriteLine($"Helo my name is {karl.name}");
            Console.WriteLine(karl.Reproduction(karl.reproduction));
            Console.WriteLine(karl.Diet(karl.diet));
            Console.WriteLine("\n");
            Console.WriteLine($"Helo my name is {willis.name}");
            Console.WriteLine(willis.Reproduction(willis.reproduction));
            Console.WriteLine(willis.Diet(willis.diet));
            Console.WriteLine("\n");
            Console.WriteLine($"Helo my name is {ernest.name}");
            Console.WriteLine(ernest.Reproduction(ernest.reproduction));
            Console.WriteLine(ernest.Diet(ernest.diet));
            Console.WriteLine("\n");
            Console.WriteLine($"Helo my name is {charlotte.name}");
            Console.WriteLine(charlotte.Legs(charlotte.legCount));
            Console.WriteLine(charlotte.Exterior(charlotte.exterior, charlotte.segmentedBody));
            Console.WriteLine("\n");
            Console.WriteLine("Thank you come again!");
            Console.Read();
        }
    }
}
