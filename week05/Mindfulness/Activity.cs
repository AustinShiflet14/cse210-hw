using System.ComponentModel;

public abstract class Activity
{
    private string _name;
    private string _description;
    protected int _duration;
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} activity!\n");
        Console.WriteLine(_description);
        Console.WriteLine("\nEnter your preferred duration of the activity in seconds:");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }
    public void End()
    {
        Console.WriteLine("\nGood job!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed the {_name} activity for {_duration} seconds.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int durationInSeconds)
    {
        string[] spinner = { " O.o", " o.o", " o.O", " o.o" };
        DateTime endTime = DateTime.Now.AddSeconds(durationInSeconds);

        int idx = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[idx] + "\r");
            idx = (idx + 1) % spinner.Length;
            Thread.Sleep(250);
        }
        Console.Write(" \r");
    }   

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b");
        }
        Console.WriteLine();
    }

    public abstract void Run();
}