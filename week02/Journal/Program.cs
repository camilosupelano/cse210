using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal(); // Journal object
        PromptGenerator promptGenerator = new PromptGenerator(); // PromptGenerator object
        MotivationalQuotes quotes = new MotivationalQuotes(); // MotivationalQuotes object

        Console.WriteLine("Welcome to your journal!");
        Console.WriteLine("Here is a motivational quote to start your day ");
        Console.WriteLine(quotes.GetRandomQuote());

        while (true) // Menu
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine(); // Read the user's choice

            if (choice == "1") // Write
            {
                DateTime theCurrentTime = DateTime.Now;
                string dateString = theCurrentTime.ToShortDateString(); // Gives format to the date obtained by DateTime.Now
                string prompt = promptGenerator.GetRandomPrompt(); 


                Console.WriteLine(prompt);
                String entry = Console.ReadLine();

                theJournal.AddEntry(new Entry(dateString, prompt, entry)); // Add the new entry to the journal

            }
            else if (choice == "2") // Display
            {
                theJournal.DisplayAll(); 
            }
            else if (choice == "3") // Load
            {
                Console.Write("What is the file name? ");
                string fileName = Console.ReadLine();
                theJournal.LoadFromFile(fileName);
            }
            else if (choice == "4") // Save
            {
                Console.Write("What is the file name? ");
                string fileName = Console.ReadLine();
                theJournal.SaveToFile(fileName);
            }
            else if (choice == "5") // Quit
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}