﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace _01.Average_Student_Grades
{
    public class Program
    {
        public static void Main()
        {
            {
                var n = int.Parse(Console.ReadLine());
                var grades = new Dictionary<string, List<double>>();
                for (int i = 0; i < n; i++)
                {
                    var nameAndGrade = Console.ReadLine().Split(' ');
                    var name = nameAndGrade[0];
                    var grade = double.Parse(nameAndGrade[1]);

                    if (!grades.ContainsKey(name))
                    {
                        grades[name] = new List<double>();
                    }
                    grades[name].Add(grade);
                }
                foreach (var nameAndGrades in grades)
                {
                    Console.WriteLine("{0} -> {1:f2} (avg: {2:f2})", nameAndGrades.Key, string.Join(" ", nameAndGrades.Value.Select
                        (p => string.Format("{0:f2}", p))),
                        nameAndGrades.Value.Average());
                }
            }
        }
    }
}
