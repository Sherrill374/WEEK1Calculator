/*LeBresha Sherrill
  10/11/2026SDC220L - Week 1 Project
  Basic Calculator Application
  */
using System;
namespace CalulatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome message 
            Console.WriteLine("Welcome to my calculator app!" +
                "\nThis application will perform basic calculations for you." +
                "\nYou will be prompted to enter two numbers and select an operation to perform." +
                "\nThe result will be displayed after the calculation is complete.");
            Console.WriteLine();
            

            //integer addition
            Console.WriteLine("Additon with Integers");  
            Console.WriteLine("You will enter two integers for addition.");
            Console.WriteLine("Please enter the first number:");
            int firstInteger = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the second number:");
            int secondInteger = Convert.ToInt32(Console.ReadLine());

            int additionResult = firstInteger + secondInteger;
            Console.WriteLine($"The result of {firstInteger} + {secondInteger} = {additionResult}");
            Console.WriteLine();

            //float-point Subtraction
            Console.WriteLine("Subtraction with Floating-Points");
            Console.WriteLine("You will enter two floating-point numbers for subtraction.");
            Console.WriteLine("Please enter the first number:");
            double firstdecimal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the second number:");
            double seconddecimal = Convert.ToDouble(Console.ReadLine());

            double subtractionResult = firstdecimal - seconddecimal;
            Console.WriteLine($"The result of {firstdecimal} - {seconddecimal} = {subtractionResult}");
            Console.WriteLine();

            //Closing Message
            Console.WriteLine("Thank you for trying my calculator app!");
            Console.WriteLine("Have a great day!");

            Console.ReadLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
} 

