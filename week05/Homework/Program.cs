using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment();
        assignment1.SetStudentName("John Doe");
        assignment1.SetTopic("Multiplication");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment();
        assignment2.SetStudentName("Jane Smith");
        assignment2.SetTopic("Fractions");
        assignment2.SetTextbookSection("Section 5.2");
        assignment2.SetProblems("1-10");
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment();
        assignment3.SetStudentName("Alice Johnson");
        assignment3.SetTopic("European History");
        assignment3.SetTitle("The Causes of World War II by Mary Waters");
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}