using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class MenuMaker
    {
        public Random Randomizer;

        string[] Meats = { "Roast Beef", "Salami", "Turkey", "Ham", "Pastrami" };
        string[] Condiments = { "Yellow Mustard", "Brown Mustard", "Honey Mustard",
                                "Mayo", "relish", "French Dressing" };
        string[] Breads = {"Rye", "White", "Wheat","Pumpernickel", "Italian Bread",
                           "A Roll"};

        public string GetMenuItem()
        {
            string randomMeat = Meats[Randomizer.Next(Meats.Length)];
            string randomCondiments = Condiments[Randomizer.Next(Meats.Length)];
            string randomBreads = Breads[Randomizer.Next(Breads.Length)];
            return randomMeat + " with " + randomCondiments + " on " + randomBreads;
        }
    }
}
