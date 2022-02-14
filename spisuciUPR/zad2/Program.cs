using System;
using System.Collections.Generic;
using System.Linq;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> endResut = new List<int>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                

                if (input[0].ToLower() == "delete")
                {
                    while (numbers.Contains(int.Parse(input[1])))
                    {
                        numbers.Remove(int.Parse(input[1]));
                    }
                    
                }

                if (input[0].ToLower() == "insert")
                {
                    numbers.Insert(int.Parse(input[2]), int.Parse(input[1]));
                }

                if (input[0].ToLower() == "even")
                {
                    foreach (var num in numbers)
                    {
                        if (num % 2 == 0 )
                        {
                            endResut.Add(num);
                        }
                    }
                    Console.WriteLine(string.Join(" ", endResut));
                    break;
                }

                if (input[0].ToLower() == "odd")
                {
                    foreach (var num in numbers)
                    {
                        if (num %2 != 0)
                        {
                            endResut.Add(num);
                        }
                    }
                    Console.WriteLine(string.Join(" ", endResut));
                    break;
                    
                }
            }


        }
    }
}
