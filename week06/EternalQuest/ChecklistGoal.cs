public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        Console.WriteLine($"You earned {_points} points!");

        if (_amountCompleted == _target)
        {
            Console.WriteLine($"Congratulations! You completed the goal and earned a bonus of {_bonus} points!");
        }
    }

    public override bool IsComplete() => _amountCompleted >= _target;
    public int GetBonus() => _bonus;

    public int GetAmountCompleted() => _amountCompleted;

    public override string GetDetailsString() =>
        $"[{(_amountCompleted >= _target ? "X" : " ")}] {_shortName} ({_description}) -- Completed {_amountCompleted}/{_target}";

    public override string GetStringRepresentation() =>
        $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_target}|{_bonus}|{_amountCompleted}";
}