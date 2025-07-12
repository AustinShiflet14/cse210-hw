using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Prompt promptGenerator = new Prompt();
        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice (1-5): ");
            choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    Console.Write("> ");
                    string response = Console.ReadLine();

                    Entry newEntry = new Entry(prompt, response);
                    journal.Add(newEntry);
                    break;

                case "2":
                    journal.Display();
                    break;

                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.Save(saveFile);
                    break;

                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.Load(loadFile);
                    break;

                case "5":
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 5.");
                    break;
            }

            Console.WriteLine();
        }
    }
}