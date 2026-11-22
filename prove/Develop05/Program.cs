using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> userGoals = new List<Goal>();
        //
        bool run = true;
        int agPoints = 0;
        int userChoice = 9;
        int userGChoice = 0;
        // These are varibles that we can use to instantiate our classes.
        string title = "";
        string desc = "";
        int points = 0; 
        int bonus = 0;
        int tally = 0;
        //
        string fileName = "goals.txt";
        string[] lines = System.IO.File.ReadAllLines(fileName);
        string goalType = "";

        Console.WriteLine("Welcome to the Goal Tracking Program!");
        while(run)
        {
            Console.Write(@$"You have {agPoints} points
            
            Menu Options:
            1. Create New Goal
            2. List Goals
            3. Save Goals
            4. Load Goals
            5. Record Event
            6. Wipe File
            0. Quit
            
        Select a choice from the menu: >  ");

        userChoice = int.Parse(Console.ReadLine());
        Console.Write("\n");

        switch (userChoice)
        {
        
            case 0:
                run = false;
                break;
            case 1:
                Console.Write(@"The Types of Goals are
        1. Simple Goal
        2. Eternal Goal
        3. Checklist Goal
What type of goal would you like to create? > ");
                userGChoice = int.Parse(Console.ReadLine());
                Console.Write("\n");

                switch (userGChoice)
                    {
                        case 1:
                            Console.Write("What is the name of your goal? > ");
                            title = Console.ReadLine();
                            Console.Write("What is a short description of it? > ");
                            desc = Console.ReadLine();
                            Console.Write("What is the amount of points associated with this goal? > ");
                            points = int.Parse(Console.ReadLine());
                            
                            userGoals.Add(new SimpleGoal(title, desc, points, false));

                            break;
                        case 2:
                            Console.Write("What is the name of your goal? > ");
                            title = Console.ReadLine();
                            Console.Write("What is a short description of it? > ");
                            desc = Console.ReadLine();
                            Console.Write("What is the amount of points associated with this goal? > ");
                            points = int.Parse(Console.ReadLine());
                            
                            userGoals.Add(new EternalGoal(title, desc, points));
                            break;
                        case 3:
                            Console.Write("What is the name of your goal? > ");
                            title = Console.ReadLine();
                            Console.Write("What is a short description of it? > ");
                            desc = Console.ReadLine();
                            Console.Write("What is the amount of points associated with this goal? > ");
                            points = int.Parse(Console.ReadLine());
                            Console.Write("How many times does this goal need to be accomplished? > ");
                            tally = int.Parse(Console.ReadLine());
                            Console.Write("What is the bonus for accomplishing it that many times? > ");
                            bonus = int.Parse(Console.ReadLine());
                            
                            userGoals.Add(new CheckListGoal(title, desc, points, bonus, tally));
                            break;
                        }

                break;
            case 2: // this will allow us to display a list of all the goals that we already have
                foreach(Goal goal in userGoals)
                {
                    goal.Display();
                }
                Console.Write("\n");
                break;
            case 3: // this will allow us to save all the goals that we have made in the cycle of this program
                foreach(Goal goal in userGoals)
                {
                    using (StreamWriter outputFile = new StreamWriter(fileName))
                    {
                        Console.WriteLine(goal.GetSaveString());
                        outputFile.WriteLine(goal.GetSaveString());
                    }
                    Console.Write("\n");
                }
                break;
            case 4: // this case will allow us to load on a file into the program and assign objects of goals to our list in this main program.
                foreach(string line in lines)
                    {
                        string[] roughParts = line.Split(":");
                        string[] parts = roughParts[1].Split(",");
                        goalType = roughParts[0];
                        
                        switch (goalType)
                        {
                            case "Simple Goal":
                                userGoals.Add(new SimpleGoal(parts[0], parts[1], int.Parse(parts[2]), bool.Parse(parts[3])));
                                break;
                            case "Eternal Goal":
                                userGoals.Add(new EternalGoal(parts[0], parts[1], int.Parse(parts[2])));
                                break;
                            case "Check List Goal":
                                userGoals.Add(new CheckListGoal(parts[0], parts[1], int.Parse(parts[2]),int.Parse(parts[2]),int.Parse(parts[4])));
                                break;
                        }  
                    }
                break;
            case 5: // This will allow us to record an event and update an object in the case that we need to.
                Console.WriteLine("These are your goals so far...");
                int index = 1;
                int choice = 0;
                int upPoint = 0;
                foreach(Goal goal in userGoals)
                {
                    Console.Write($"{index}.) ");
                    goal.Display();
                    index ++;
                }
                Console.Write("Which Goal did you accomplish? ");
                choice = int.Parse(Console.ReadLine());
                upPoint = userGoals[choice-1].Progress();
                agPoints += upPoint;
                Console.WriteLine($"Congratulations! You have earned {upPoint}");
                break;
            case 6:
                File.WriteAllText(fileName, "");
                break;
            }

            Console.Write("\n"); // Give space to the program above
        }
        
    }
}