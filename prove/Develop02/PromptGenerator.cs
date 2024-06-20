public class PromptGenerator{
    public List<string> _prompt = new List<string> {"If you could create a piece of art (a painting, a song, a novel), what would it be about? Describe the themes and emotions you would want to convey.",
    "List three things you are grateful for today and describe why each one is meaningful to you.","Reflect on your day. What was the best part, and what could you have done differently?",
    "What am I thankful for today?", "What is a favorite childhood memory that still brings me joy?", "What is one quote or saying that inspires me, and how can I apply its wisdom to my life?"};

    public string GetRandomPrompt(){
        Random random = new Random();
        int randomIndex = random.Next(_prompt.Count);
        string randomPrompt = _prompt[randomIndex];
        return randomPrompt;
    }

}