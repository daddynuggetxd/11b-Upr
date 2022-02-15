using System;
using System.Collections.Generic;
using System.Linq;

namespace KursoveGrafik
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> subjects = Console.ReadLine().Split(", ").ToList();

            while (true)
            {
                string[] input = Console.ReadLine().Split(":");
                if (input[0]== "course start")
                {
                    foreach (var subject in subjects)
                    {
                        Console.WriteLine($"{subjects.IndexOf(subject) + 1} : {subject}");
                    }
                    break;
                }

                if (input[0] == "Add")
                {
                    if (!subjects.Contains(input[1]))
                    {
                        subjects.Add(input[1]);
                    }
                    
                }

                if (input[0] == "Insert")
                {
                    if (!subjects.Contains(input[1]))
                    {
                        subjects.Insert(int.Parse(input[2]), input[1]);
                    }
                   
                }

                if (input[0] == "Remove" && subjects.Contains(input[1]))
                {
                    subjects.Remove(input[1]);
                }


                

                if (input[0] == "Excercise")
                {
                    if (subjects.Contains(input[1]))
                    { 
                        subjects.Insert(subjects.IndexOf(input[1]) + 1, input[1] + "- Excercise");
                       
                    }

                    if (!subjects.Contains(input[1]))
                    {
                        subjects.Add(input[1]);
                        subjects.Insert(subjects.IndexOf(input[1]) + 1, input[1] + "- Excercise");
                    }
                }

                if (input[0] == "Swap")
                {
                    if (subjects.Contains(input[1]) && subjects.Contains(input[2]))
                    {
                        if (!subjects.Contains(input[1] + "- Excercise") && !subjects.Contains(input[2] + "- Excercise"))
                        {
                            int element1 = subjects.IndexOf(input[1]);
                            int element2 = subjects.IndexOf(input[2]);

                            string temp = subjects[element1];
                            subjects[element1] = subjects[element2];
                            subjects[element2] = temp;

                        }

                        if (subjects.Contains(input[1] + "- Excercise"))
                        {
                            int lesson = subjects.IndexOf(input[1]);
                            int lessonE = subjects.IndexOf(input[1] + "- Excercise");
                            int secondLesson = subjects.IndexOf(input[2]);

                            string temp = subjects[lesson];

                            subjects[lesson] = subjects[secondLesson];

                            subjects[secondLesson] = temp;

                            // t te r
                            //r t te


                            string tempE = subjects[lesson];

                            subjects[lesson] = subjects[lessonE];

                            subjects[lessonE] = tempE;



                        }

                        if (subjects.Contains(input[2] + "- Excercise"))
                        {
                            int t = subjects.IndexOf(input[2]);
                            int te = subjects.IndexOf(input[2] + "- Excercise");
                            int r = subjects.IndexOf(input[1]);

                            //r t te

                            //t r te
                            string temp = subjects[r];
                            subjects[r] = subjects[t];
                            subjects[t] = temp;

                            //t r te
                            //t te r

                            string temp2 = subjects[r];
                            subjects[r] = subjects[te];
                            subjects[te] = temp2;
                        }
                    }
                }
            }
        }
    }
}
