using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction myFraction = new Fraction();
        Random rand = new Random();

        for (int i = 0; i < 20; i ++)
        {
            myFraction.SetTop(rand.Next(1, 50));
            myFraction.SetBottom(rand.Next(1,50));
            Console.WriteLine($"Fraction: {i+1} String: {myFraction.GetFractionString()} Number: {myFraction.GetTop()}");

        }

    }
}