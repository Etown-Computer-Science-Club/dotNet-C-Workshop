using System;
using System.Collections.Generic;
using System.Linq;

var students = new List<(string Name, int Score)>
{
    ("James", 95), ("Sarah", 82), ("Liam", 70), ("Olivia", 88), ("Mia", 95)
};

var topStudents = students
    .Where(s => s.Score >= 85)
    .OrderByDescending(s => s.Score)
    .ThenBy(s => s.Name)
    .Select(s => $"{s.Name} ({s.Score})")
    .ToList();

Console.WriteLine("Top Students:");
topStudents.ForEach(s => Console.WriteLine($" - {s}"));

var avg = students.Average(s => s.Score);
Console.WriteLine($"Average score: {avg:F1}");
