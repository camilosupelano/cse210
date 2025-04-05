using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();

                Console.Write("How long, in seconds, would you like for your session? ");
                int duration = int.Parse(Console.ReadLine());

                activity.SetDuration(duration);
                activity.Run();

                Console.WriteLine("Press Enter to return to the menu...");
                Console.ReadLine();
            }
            else if (choice == "2")
            {
                ReflectingActivity activity = new ReflectingActivity();
                activity.Run();

                Console.WriteLine("Press Enter to return to the menu...");
                Console.ReadLine();
            }
            
            else if (choice == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();

                Console.WriteLine("Press Enter to return to the menu...");
                Console.ReadLine();
            }
            else if (choice == "4")
            {
                running = false;
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                Console.WriteLine("Press Enter to return to the menu...");
                Console.ReadLine();
            }
    
                
        }
    }
}