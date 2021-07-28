using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using 

namespace LunchBuddy
{
    class LunchBudTed
    {
        public string First { get; set; }
        public string Last { get; set; }
        
        public LunchBudTed(string first, string last)
        {
            First = first;
            Last = last;
        }

        public void Eat()
        {
            var restaurant = new Restaurant();
            Console.WriteLine($"{First} {Last} is at {restaurant.Name}");
        }

        public void Eat(string food)
        {
            Console.WriteLine($"{First} {Last} ate a {food} at the office.");
        }

        public void Eat(List<LunchBudTed> companions)
        {
            var restaurant = new Restaurant();
            Console.WriteLine($"{First} {Last} is at {restaurant.Name} with ");
            foreach (var companion in companions)
            {
                Console.WriteLine($"{companion.First}");
            }
           
        }

        public void Eat(string food, List<LunchBudTed> companions)
        {
            var restaurant = new Restaurant();

            Console.WriteLine($"{First} is eating {food} at {restaurant.Name} with ");
            foreach (var companion in companions)
            {
                Console.WriteLine($"{companion.First}");
            }
        }
    }
}
