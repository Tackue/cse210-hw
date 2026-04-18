public class ChecklistGoal : Goal
{
    private int _target;
    private int _count;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _count = 0;
    }

    public override int RecordEvent()
    {
        _count++;

        int total = _points;

        if (_count == _target)
        {
            total += _bonus;
        }

        return total;
    }

    public override bool IsComplete()
    {
        return _count >= _target;
    }

    public override string GetStatus()
    {
        return IsComplete() ? "[X]" : "[ ]";
    }

    public override string GetDetails()
    {
        return $"{GetStatus()} {_name} ({_description}) -- {_count}/{_target}";
    }
}