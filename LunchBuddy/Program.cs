using System;
using System.Collections.Generic;
//using LunchBuddy.LunchBudTed;
namespace LunchBuddy
{
    class Program
    {
        static void Main(string[] args)
        {
            var ted = new LunchBudTed("Ted", "Person");
            ted.Eat();
            ted.Eat("cucumber sandwich");
            ted.Eat(new List<LunchBudTed>
                {
                new LunchBudTed("Dennis", "Rodman"),
                new LunchBudTed("Bill", "Laimbeer")

        });
            ted.Eat(new List<LunchBudTed>
                {
                new LunchBudTed("Rick", "Mahorn"),
                new LunchBudTed("Joe", "Dumars")

        });
        }
            
        
    }
}
