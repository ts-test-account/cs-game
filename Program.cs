using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleGame
{
    public class Program
    {
        static public void Main ()
        {
            Console.WriteLine ("Hello Mono World");
            string[] names = {"Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra"};
            var query = names.Where(s => s.Length <= 5);
            
            foreach (var item in query)
                Console.WriteLine(item);
            Console.WriteLine("----");
            
            names[0] = "Osaka";
            
            foreach(var item in query)
                Console.WriteLine(item);
                
            Actor actor = new Actor();
            actor.TestMethod();
            
        }
    }
}

