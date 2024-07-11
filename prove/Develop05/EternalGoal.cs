public class EternalGoal : Goal{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points){

    }

    public override void RecordEvent(){
        // Eternal goals don't complete
    }

    public override bool IsComplete() => false;

    public override string GetDetailsString(){
        return $"{GetName()}: [∞] - {GetPoints()} points per record";
    }

    public override string GetStringRepresentation(){
        return $"EternalGoal|{GetName()}|{GetPoints()}";
    }
}
