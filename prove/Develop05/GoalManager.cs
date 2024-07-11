public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private const string FilePath = "goals.txt";

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Player Info");
            Console.WriteLine("4. List Goal Details");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoalNames();
                    Console.Write("Choose a goal to record event: ");
                    int goalIndex = int.Parse(Console.ReadLine()) - 1;
                    RecordEvent(goalIndex);
                    break;
                case 3:
                    DisplayPlayerInfo();
                    break;
                case 4:
                    ListGoalDetails();
                    break;
                case 5:
                    SaveGoals();
                    break;
                case 6:
                    LoadGoals();
                    break;
                case 7:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score}");
        ListGoalNames();
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Choose goal type: 1. Simple, 2. Eternal, 3. Checklist");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        Goal goal = null;

        switch (choice)
        {
            case 1:
                goal = new SimpleGoal(name, description, points);
                break;
            case 2:
                goal = new EternalGoal(name, description, points);
                break;
            case 3:
                Console.Write("Enter target count: ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());

                goal = new ChecklistGoal(name, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }

        _goals.Add(goal);
        Console.WriteLine("Goal created successfully.");
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex < 0 || goalIndex >= _goals.Count)
        {
            Console.WriteLine("Invalid goal index.");
            return;
        }

        var goal = _goals[goalIndex];
        goal.RecordEvent();
        _score += goal.GetPoints();

        if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
        {
            _score += checklistGoal.GetBonusPoints();
        }

        Console.WriteLine("Event recorded successfully.");
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter(FilePath))
        {
            writer.WriteLine(_score);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        if (!File.Exists(FilePath))
        {
            Console.WriteLine("No saved goals found.");
            return;
        }

        using (StreamReader reader = new StreamReader(FilePath))
        {
            _score = int.Parse(reader.ReadLine());
            _goals.Clear();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split('|');
                string type = parts[0];
                string name = parts[1];
                int points = int.Parse(parts[2]);

                switch (type)
                {
                    case "SimpleGoal":
                        bool isComplete = bool.Parse(parts[3]);
                        var simpleGoal = new SimpleGoal(name, "", points);
                        if (isComplete) simpleGoal.RecordEvent(); // Mark as complete if it was loaded as complete
                        _goals.Add(simpleGoal);
                        break;

                    case "EternalGoal":
                        var eternalGoal = new EternalGoal(name, "", points);
                        _goals.Add(eternalGoal);
                        break;

                    case "ChecklistGoal":
                        int amountCompleted = int.Parse(parts[3]);
                        int target = int.Parse(parts[4]);
                        int bonus = int.Parse(parts[5]);
                        var checklistGoal = new ChecklistGoal(name, "", points, target, bonus);
                        checklistGoal.SetAmountCompleted(amountCompleted); // Assuming you have a method to set this directly
                        _goals.Add(checklistGoal);
                        break;
                }
            }
        }
        Console.WriteLine("Goals loaded successfully.");
    }
}
