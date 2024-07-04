public class BreathingActivity : Activity {
    public BreathingActivity(){
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run() {
        DisplayStartingMessage();
        int halfDuration = _duration / 2;
        for (int i = 0; i < halfDuration; i++) {
            Console.WriteLine("Breathe in...");
            ShowCountdown(4);
            Console.WriteLine("Breathe out...");
            ShowCountdown(4);
        }
        DisplayEndingMessage();
    }
}