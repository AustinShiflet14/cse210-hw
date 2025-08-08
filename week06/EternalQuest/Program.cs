// Creativity:
// Leveling Up - The user levels up every 1000 points.
// Streaks - Tracks how many days in a row goals are completed.
using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}