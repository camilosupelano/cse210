using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> ();

        int number = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            
            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        int sum = 0;

        // Calculate the sum of the numbers

        foreach (int num in numbers)
        {
            sum += num;
        }

        Console.WriteLine($"The sum is: {sum}");

        // Calculate the average of the numbers

        float average = (float)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Calculate the largest number

        int largest = numbers[0];

        foreach (int num in numbers)
        {
            if (num > largest)
            {
                largest = num;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");


    }
}