using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a = new Assignment("John", "Math-Homework-Advanced-Calc");
        MathAssignment m = new MathAssignment("Mary","Math","Section 1A","6^64534+4=4a");
        WritingAssignment w = new WritingAssignment("Lue","English","This is the Time");
        Console.WriteLine(a.GetSummary());
        Console.WriteLine(m.GetHomeworkList());
        Console.WriteLine(w.GetWritingInfromation());

    }
}