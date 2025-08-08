// Leveling System - The user levels up every 1000 points.
// Streak Tracker - Tracks how many days in a row goals are completed.
// Badge Unlock - Unlocks a special message when the user hits 5000 points.
using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}