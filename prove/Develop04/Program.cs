using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity act1 = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 10);//activity 1
        ReflectionActivity act2 = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life", 10); //activity 2
        ListingActivity act3 = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 10);// act 3


        bool run = true;

        Console.WriteLine(@"Welcome to the Mindfulness App!");
        Thread.Sleep(1500);
        Console.Clear();

        while (run)
        {
            Console.Write(@"
Menu Options:
1 = Breathing Activity
2 = Reflection Activity
3 = Listing Activity
4 = Quit
Please Type a Selection from the Menu: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("act1");
                    Console.Write("Get ready...");
                    act1.ShowSpinner(2);
                    act1.Start();
                    break;
                case "2":
                    Console.WriteLine("act2");
                    Console.Write("Get ready...");
                    act2.ShowSpinner(2);
                    act2.Start();
                    break;
                case "3":
                    Console.WriteLine("act3");
                    Console.Write("Get ready...");
                    act3.ShowSpinner(2);
                    act3.Start();
                    break;
                case "4":
                    Console.WriteLine("Quit");
                    run = false;
                    break;
            }

            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}