public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(
        string name,
        string description,
        int points,
        int target,
        int bonus)
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;

        int pointsEarned = GetPoints();

        if (_amountCompleted == _target)
        {
            pointsEarned += _bonus;
        }

        return pointsEarned;
    }

    public override string GetDetailsString()
    {
        string status = _amountCompleted >= _target ? "X" : " ";

        return $"[{status}] {GetName()} -- Completed {_amountCompleted}/{_target} times";
    }
}