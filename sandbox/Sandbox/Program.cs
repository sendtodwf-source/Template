
            using System;

            class Prog
            {
                static void Main()
                {
                    try
                    {
                        // Attempt to divide by zero
                        int numerator = 10;
                        int denominator = 0;
                        int result = numerator / denominator;
                        Console.WriteLine("Result: " + result);
                    }
                    catch (DivideByZeroException ex)  //Handle only divide by 0 exception
                    {
                        Console.WriteLine("Error: Cannot divide by zero.");
                        Console.WriteLine("Exception message: " + ex.Message);
                    }
                    catch (Exception ex)  // Catches all other exceptions
                    {
                        Console.WriteLine("Error: Exception Occurred");
                        Console.WriteLine("Exception message: " + ex.Message);
                    }
                    finally
                    {
                        Console.WriteLine("This block always executes, regardless of exceptions.");
                    }
                }
            }