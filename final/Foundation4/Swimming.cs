public class Swimming : Activity
    {
        private int laps;

        public Swimming(DateTime date, int durationInMinutes, int laps)
            : base(date, durationInMinutes)
        {
            this.laps = laps;
        }

        public override double GetDistance() => (laps * 50) / 1000.0;

        public override double GetSpeed() => (GetDistance() / DurationInMinutes) * 60;

        public override double GetPace() => DurationInMinutes / GetDistance();
    }