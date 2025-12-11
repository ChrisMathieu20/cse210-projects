public class GoalManager
{
    private List<string> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = [];
        _score = 0;
    }

    public void Start()
    {
        bool isQuit = false;
        while (!isQuit)
        {
            DisplayPlayerInfo();
            Console.WriteLine("Menu options:\n1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit");
            Console.Write("Select a choice from menu: ");
            string userEntry = Console.ReadLine();
            int choice = int.Parse(userEntry);
            if (choice != 6)
            {
                isQuit = false;
                if (choice == 1)
                {
                    CreateGoal();
                }
                else if (choice == 2)
                {
                    ListGoalDetails();
                }
                else if (choice == 3)
                {
                    SaveGoals();
                }
                else if (choice == 4)
                {
                    LoadGoals();
                }
                else if (choice == 5)
                {
                    RecordEvent();
                }
            }
            else
            {
                isQuit = true;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.\n");
    }

    public void ListGoalNames()
    {
        int i = 0;
        foreach (string items in _goals)
        {
            string[] item = items.Split(":");
            string details = item[1];
            string[] element = details.Split(",");
            string names = element[0].ToString();
            i++;
            Console.WriteLine($"{i}. {names}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The Goals are:");
        int i = 0;
        foreach (string items in _goals)
        {
            i++;
            string[] item = items.Split(":");
            string className = item[0].ToString();
            string details = item[1].ToString();
            if (className == "SimpleGoal")
            {
                string[] elements = details.Split(",");
                string name = elements[0].ToString();
                string description = elements[1].ToString();
                int points = int.Parse(elements[2]);
                bool isComplete = bool.Parse(elements[3]);
                Console.WriteLine($"{i}. [ ] {name} ({description})");
            }
            else if (className == "EternalGoal")
            {
                string[] elements = details.Split(",");
                string name = elements[0].ToString();
                string description = elements[1].ToString();
                int points = int.Parse(elements[2]);
                Console.WriteLine($"{i}. [ ] {name} ({description})");
            }
            if (className == "ChecklistGoal")
            {
                string[] elements = details.Split(",");
                string name = elements[0].ToString();
                string description = elements[1].ToString();
                int points = int.Parse(elements[2]);
                int bonus = int.Parse(elements[3]);
                int target = int.Parse(elements[4]);
                int amountCompleted = int.Parse(elements[5]);
                Console.WriteLine($"{i}. [ ] {name} ({description}) -- Current completed: {amountCompleted}/{target}");
            }
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string userSelect = Console.ReadLine();
        int select = int.Parse(userSelect);
        if (select == 1)
        {
            Console.Write("What is the name of your goal? ");
            string goalName = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string goalDescription = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string entryPoints = Console.ReadLine();
            int goalPoints = int.Parse(entryPoints);
            SimpleGoal simpleGoal = new SimpleGoal(goalName,goalDescription,goalPoints);
            _goals.Add(simpleGoal.GetStringRepresentation());
        }
        else if (select == 2)
        {
            Console.Write("What is the name of your goal? ");
            string goalName = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string goalDescription = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string entryPoints = Console.ReadLine();
            int goalPoints = int.Parse(entryPoints);
            EternalGoal eternalGoal = new EternalGoal(goalName,goalDescription,goalPoints);
            _goals.Add(eternalGoal.GetStringRepresentation());
        }
        else if (select == 3)
        {
            Console.Write("What is the name of your goal? ");
            string goalName = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string goalDescription = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string entryPoints = Console.ReadLine();
            int goalPoints = int.Parse(entryPoints);
            Console.Write("How many times does this goal to be accomplished for a bonus? ");
            string entryTimes = Console.ReadLine();
            int goalTarget = int.Parse(entryTimes);
            Console.Write("What is the bonus for accomplishing it that many times? ");
            string entryBonus = Console.ReadLine();
            int goalBonus = int.Parse(entryBonus);
            ChecklistGoal checklistGoal = new ChecklistGoal(goalName,goalDescription,goalPoints,goalTarget,goalBonus);
            _goals.Add(checklistGoal.GetStringRepresentation());
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        string userAnswer = Console.ReadLine();
        int ans = int.Parse(userAnswer);
        int score = 0;
        if (ans == 1)
        {}
        else if (ans == 2)
        {}
        else if (ans == 3)
        {}
        SetScore(score);
    }

    public void SaveGoals()
    {
        Console.Write("What is the name of the file: ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (string goal in _goals)
            {
                outputFile.WriteLine(goal);
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the name of the file: ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        for (int i = 1; i < lines.Length; i++)
        {
            _goals.Add(lines[i]);
        }
    }

    public int GetScore()
    {
        return _score;
    }

    public void SetScore(int score)
    {
        _score = score;
    }
}