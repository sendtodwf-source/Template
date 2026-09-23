using System;

    class Program
    {
        static void Main(string[] args)
        {
        
        List <float> myList = new List <float>();

        string input = "Null";
        float aInput = 0;
        bool flag = false;
        float rTotal = 0;
        int count = 0;
        float avg = 0;
        float bigNum = 0;


        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        do
        {
            Console.Write("Enter number: ");
            input = Console.ReadLine();
            aInput = float.Parse(input);

            if (aInput == 0)
            {
                flag = true;
            }
            else
            {
                myList.Add(aInput);
            }
        }
        while (flag == false);

        foreach (int num in myList)
        {
            rTotal += num;
            count++;
            if (num>bigNum)
            {
                bigNum = num;
            }
        }

        avg = rTotal/count;

        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {bigNum}");
        
    }
}
/*or ||
and &&
not !
equals ==
*/



