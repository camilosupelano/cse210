using System;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public GoalManager()
    {
    }

    public void Start()
    {
        string choice = ""; 

        while (choice != "6")
        {
            DisplayPlayerInfo();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create new Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    ListGoalNames();
                    RecordEvent();
                    break;
                case "6":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;

            }

        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.\n");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are: ");
        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetShortName()}");
            index++;
        }
        Console.WriteLine();
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are: ");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
        Console.WriteLine();
    }

    public void CreateGoal()
    {
        Console.WriteLine("What type of goal would you like to create?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Select a choice from the menu: ");
        string choice = Console.ReadLine();

        Console.WriteLine("What is the name of your goal?");
        string name = Console.ReadLine();
        Console.WriteLine("What is a short description of it?");
        string description = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal?");
        int  points = int.Parse(Console.ReadLine());

        if (choice == "1")
        {
            SimpleGoal simple = new SimpleGoal(name, description, points, false);
            _goals.Add(simple);
        }
        else if (choice == "2")
        {
            EternalGoal eternal = new EternalGoal(name, description, points);
            _goals.Add(eternal);
        }
        else if (choice == "3")
        {
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
            int target = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the bonus for accomplishing it that many times?");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal checklist = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklist);            
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }

    }

     public void RecordEvent()
    {
        
        Console.WriteLine("Which goal did you accomplish?");
        int index = int.Parse(Console.ReadLine()) - 1;

        Goal goal = _goals[index];
        goal.RecordEvent();
        
        if (goal is ChecklistGoal checklist)
        {
            _score += checklist.GetPoints();

            if (checklist.IsComplete())
            {
                _score += checklist.GetBonus();
            }
        }
        else if (goal is SimpleGoal || goal is EternalGoal)
        {
            _score += goal.GetPoints();
        }
       
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }
    } 

    public void SaveGoals()
    {
        Console.WriteLine("Enter the filename to save goals: ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine($"Goals and score saved successfully to {filename}.");
    }
    
    public void LoadGoals()
    {
        Console.Write("Enter the filename to load goals: ");
        string filename = Console.ReadLine();

        string[] lines = File.ReadAllLines(filename);

        _goals.Clear();
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            string type = parts[0];

            if (type == "SimpleGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool isComplete = bool.Parse(parts[4]);
                
                SimpleGoal goal = new SimpleGoal(name, description, points, isComplete);
                if (isComplete)
                {
                    goal.RecordEvent(); 
                }
                _goals.Add(goal);
            }
            else if (type == "EternalGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                EternalGoal goal = new EternalGoal(name, description, points);
                _goals.Add(goal);
            }
            else if (type == "ChecklistGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                int bonus = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int amountCompleted = int.Parse(parts[6]);

                ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
                for (int j = 0; j < amountCompleted; j++)
                {
                    goal.RecordEvent(); 
                }
                _goals.Add(goal);
            }

        }
        Console.WriteLine($"Goals loaded successfully from {filename}.\n");
    }
        
    
}