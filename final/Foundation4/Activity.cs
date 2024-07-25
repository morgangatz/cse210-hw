public abstract class Activity
    {
        private DateTime date;
        private int durationInMinutes;

        public Activity(DateTime date, int durationInMinutes)
        {
            this.date = date;
            this.durationInMinutes = durationInMinutes;
        }

        public DateTime Date => date;
        public int DurationInMinutes => durationInMinutes;

        public abstract double GetDistance();
        public abstract double GetSpeed(); // Speed in kph
        public abstract double GetPace();  // Pace in min/km

        public virtual string GetSummary()
        {
            return $"{Date.ToShortDateString()} {GetType().Name} ({DurationInMinutes} min): Distance {GetDistance():0.0} km, Speed {GetSpeed():0.0} kph, Pace {GetPace():0.0} min/km";
        }
    }