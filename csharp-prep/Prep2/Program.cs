using System;

class Program
{
    static void Main(string[] args)
    {
        int userGrade = -1;
        string letter = "Null";
        /*
        A >= 90
        B >= 80
        C >= 70
        D >= 60
        F < 60
        */
        Console.WriteLine("This program is used to give grading, give a number between 0-100");
        string userGradeStr= Console.ReadLine();
        userGrade = int.Parse(userGradeStr);

        if (userGrade >= 90)
        {
            Console.WriteLine("A");
            letter = "A";

        }
        else if (userGrade >= 80)
        {
            Console.WriteLine("B");
            letter = "B";

        }
        else if (userGrade >= 70)
        {
            Console.WriteLine("C");
            letter = "C";

        }
        else if (userGrade >= 60)
        {
            Console.WriteLine("D");
            letter = "D";

        }
        else if (userGrade < 60)
        {
            Console.WriteLine("man I'm so sorry you got an F");
            letter = "F";
        }
        else
        {
            Console.WriteLine("Restart and enter a valid grade");
        }
        
        if (userGrade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course!");
        }
        Console.WriteLine(letter);

    }
}