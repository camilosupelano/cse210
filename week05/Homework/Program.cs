using System;

class Program
{
    static void Main(string[] args)
    {
        
        Assignment assignHw = new Assignment ("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignHw.GetSummary());
        Console.WriteLine();
        
        MathAssignment mathHw = new MathAssignment("John Doe", "Algebra", "7.3", "8-19"); Console.WriteLine(mathHw.GetSummary());
        Console.WriteLine(mathHw.GetHomeworkList());
        Console.WriteLine();
        
        
        WritingAssignment writingHw = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(writingHw.GetSummary());
        Console.WriteLine(writingHw.GetWritingInformation());
        Console.WriteLine();
        

    }
}