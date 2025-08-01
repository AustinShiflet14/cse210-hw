public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string> {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string> {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different?",
        "What is your favorite thing about this experience?",
        "What did you learn about yourself?",
        "How can you apply this lesson in the future?"
    };

    public ReflectionActivity() : base(
        "Reflection", 
        "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    { }

    public override void Run()
    {
        Start();
        Console.Clear();
        Random rand = new Random();
        Console.WriteLine("\nPrompt:");
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);
        Console.WriteLine();

        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.WriteLine(_questions[rand.Next(_questions.Count)]);
            ShowSpinner(6);
            elapsed += 6;
        }

        End();
    }
}