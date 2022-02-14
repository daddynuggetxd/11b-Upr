using System;
using System.Collections.Generic;
using System.Linq;

namespace spisuciUPR
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
           

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0].ToLower()== "end")
                {
                    break;
                }

                if (input[0].ToLower() == "add")
                {
                    numbers.Add(int.Parse(input[1]));
                }
                if (input[0].ToLower() == "remove" )
                {
                    if (numbers.Contains(int.Parse(input[1])))
                    {
                        numbers.Remove(int.Parse(input[1]));
                    }
                    else
                    {
                        Console.WriteLine("Specified number isn't in the list");
                    }
                }
                if (input[0].ToLower() == "removeat")
                {
                    numbers.RemoveAt(int.Parse(input[1]));
                }
                if (input[0].ToLower() == "insert")
                {
                    numbers.Insert(int.Parse(input[2]), int.Parse(input[1]));
                }
               
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
