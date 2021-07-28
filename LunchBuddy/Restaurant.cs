using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchBuddy
{
    class Restaurant
    {
        private List<string> restaurantNames = new List<string> { "Central", "Sketch", "Maido", "Dishoom", "Folk" };
        public string Name;
        public Restaurant()
        {
            Random rand = new Random();
            var index = rand.Next(restaurantNames.Count);
            Name = restaurantNames[index];
        }
    }
}
