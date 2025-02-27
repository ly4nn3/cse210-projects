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

    public override int RecordEvent()
    {
        _amountCompleted++;
        
        if (_amountCompleted == _target)
        {
            Congratulations.ShowCongratulations(GetName(), GetPoints() + _bonus);
            return GetPoints() + _bonus;
        }
        else
        {
            Console.WriteLine($"\nYou've completed this goal {_amountCompleted}/{_target} times!");
            Congratulations.ShowSpinner(1);
            return GetPoints();
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetails()
    {
        string completionMark = IsComplete() ? "[X]" : "[ ]";
        return $"{completionMark} {GetName()} ({GetDescription()} -- Currently completed: {_amountCompleted}/{_target} times)";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_target}|{_bonus}|{_amountCompleted}";
    }
}