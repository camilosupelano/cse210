using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
       
        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\scriptures.txt");

        ScriptureLoader loader = new ScriptureLoader();
        List<Scripture> scriptures = loader.LoadScripturesFromFile(filePath); 

        if (scriptures.Count == 0)
        {
            Console.WriteLine("Error: No scripture found");
            return;
        }

        Random rand = new Random();
        Scripture scripture = scriptures[rand.Next(scriptures.Count)];

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(2);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("Now say the whole scripture.");
    }
}
