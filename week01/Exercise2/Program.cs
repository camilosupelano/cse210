using System;

class Program
{
    static void Main(string[] args)
    {
        string letter = "";

        Console.WriteLine("What is your grade?");
        string gradeInput = Console.ReadLine();
        int grade = int.Parse(gradeInput);

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if(grade >= 70)
        {
            Console.WriteLine($"Congratulations! You passed with a {letter} grade!!");
        }
        else
        {
            Console.WriteLine($"Your grade is {letter} continue studying so you get it next time");
        }
    }
}