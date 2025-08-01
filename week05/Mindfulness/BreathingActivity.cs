public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing", 
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    { }

    public override void Run()
    {
        Start();
        int elapsed = 0;
        int cycle = 10;

        while (elapsed < _duration)
        {
            Console.Write("Breathe in...");
            ShowCountdown(5);;
            Console.Write("Now breathe out...");
            ShowCountdown(5);
            elapsed += cycle;
        }

        End();
}
}