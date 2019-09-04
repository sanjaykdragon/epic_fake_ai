using System;
using System.Collections.Generic;
using System.Linq;

namespace epic_fake_ai
{
    class Program
    {
        public static List<int> valid_numbers = new List<int> { };
        static void Main(string[] args)
        {
            int minimum_number = 0;
            int max_number = 10; //game allows numbers from 0 to 10

            for (int i = minimum_number; i < max_number; i++)
                valid_numbers.Add(i); //setup possible guesses

            Random rnd = new Random();
            var possible_nums = valid_numbers;

            while (true)
            {
                int guessed_int = possible_nums[rnd.Next(0, possible_nums.Count)];
                Console.WriteLine("is the number {0}?", guessed_int);

                string response = Console.ReadLine();
                if (response.ToLower().Substring(0,1) == "y") //as long as first letter is y (can be y, ye, yes), will be accepted
                {
                    valid_numbers.Add(guessed_int);
                    possible_nums = valid_numbers; //reset game basically
                    Console.WriteLine("added");
                }
                else
                {
                    possible_nums = possible_nums.Where(x => x != guessed_int).ToList(); // Wow ! cool LINQ in 2019!!!!!!!1111!!1111
                }
            }
        }
    }
}
