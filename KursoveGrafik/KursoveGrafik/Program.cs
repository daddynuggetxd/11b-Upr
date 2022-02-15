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
                    if (subjects.Contains(input[1] + "- Excercise"))
                    {
                        subjects.Remove(input[1] + "- Excercise");
                    }
                }


                

                if (input[0] == "Exercise")
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


                            //l le s



                            string temp = subjects[lesson];
                            subjects[lesson] = subjects[secondLesson]; //l =s le s
                            subjects[secondLesson] = subjects[lessonE];
                            subjects[lessonE] = temp;
                            
                        }

                        if (subjects.Contains(input[2] + "- Excercise"))
                        {
                            int lesson = subjects.IndexOf(input[2]);
                            int lessonE = subjects.IndexOf(input[2] + "- Excercise");
                            int secondLesson = subjects.IndexOf(input[1]);

                            //second , L , LE
                            string temp = subjects[lesson];
                            string temp2 = subjects[secondLesson];
                            subjects[lesson] = subjects[lessonE];
                            subjects[secondLesson] = temp;
                            subjects[lessonE] = temp2;

                            
                            
                            
                        }
                    }
                }
            }
        }
    }
}
