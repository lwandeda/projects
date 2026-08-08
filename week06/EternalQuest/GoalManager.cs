public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void DisplayScore()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void DisplayGoals()
    {
        Console.WriteLine("The goals are:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateSimpleGoal()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        SimpleGoal goal = new SimpleGoal(name, description, points);

        _goals.Add(goal);

        Console.WriteLine("Goal created successfully!");
    }

    public void CreateEternalGoal()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        EternalGoal goal = new EternalGoal(name, description, points);

        _goals.Add(goal);

        Console.WriteLine("Goal created successfully!");
    }

    public void CreateChecklistGoal()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        Console.Write("How many times does this goal need to be completed? ");
        int target = int.Parse(Console.ReadLine());

        Console.Write("What is the bonus for completing it? ");
        int bonus = int.Parse(Console.ReadLine());

        ChecklistGoal goal = new ChecklistGoal(
            name,
            description,
            points,
            target,
            bonus
        );

        _goals.Add(goal);

        Console.WriteLine("Goal created successfully!");
    }

    public void RecordEvent()
    {
        DisplayGoals();

        Console.Write("Which goal did you accomplish? ");

        int choice = int.Parse(Console.ReadLine());

        int index = choice - 1;

        int pointsEarned = _goals[index].RecordEvent();

        _score += pointsEarned;

        Console.WriteLine($"Congratulations! You earned {pointsEarned} points.");
        Console.WriteLine($"Your score is now {_score}.");
    }
}