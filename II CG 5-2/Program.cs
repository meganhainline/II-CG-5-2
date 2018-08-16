using System;

namespace CG_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //This part of the code asks the user for the data that will be used to make the calculations throughout the program

            Console.WriteLine("Welcome to my calculator!");
            Console.WriteLine("Please enter one number, press enter and then enter a second number.");

            //This converts input numbers the user provides and converts them to integers
            int Input1 = int.Parse(Console.ReadLine());
            int Input2 = int.Parse(Console.ReadLine());

            //Asks the user to decide on what function the calculator needs to perform on the integers
            Console.WriteLine("Please pick one of the following functions to perform:");
            Console.WriteLine("Add, Subtract, Multiply, Divide");

            //This variable is taking the input from the user and making it accessible for the if statement that will be doing the calculations
            var operation = Console.ReadLine();

            //if statements for chosen function

            if (operation == "add")
            {
                Console.WriteLine(Addition(Input1, Input2));
            }

            else if (operation == "subtract")
            {
                Console.WriteLine(Subtraction(Input1, Input2));
            }

            else if (operation == "multiply")
            {
                Console.WriteLine(Multiply(Input1, Input2));
            }

            else if (operation == "divide")
            {
                Console.WriteLine(Divide(Input1, Input2));
            }

            else
            {
                Console.WriteLine("Sorry, I don't understand.");
            }


            Console.ReadLine();
            //I really don't think I get XML comments. I had help from a classmate on these

        }/// <summary>
         /// This method is to add the user inputed integers
         /// </summary>
         /// <param name="input1- number 1-1000"></param>
         /// <param name="input2 - number 1-1000"></param>
         /// <returns>Adds input1 to input2 and outputs total
         /// </returns>        
        public static int Addition(int input1, int input2)
        {
            return input1 + input2;

        }

        /// <summary>
        /// This method is to subtract the user inputed integers 
        /// </summary>
        /// <param name="input1 - number 1-1000"></param>
        /// <param name="input2 - number 1-1000"></param>
        /// <returns>Subtracts input1 from input2 and outputs the difference
        /// </returns>
        public static int Subtraction(int input1, int input2)
        {
            return input1 - input2;
        }

        /// <summary>
        /// This method is to multiply the user inputed integers
        /// </summary>
        /// <param name="input1 - number 1-1000"></param>
        /// <param name="input2 - number 1-1000"></param>
        /// <returns>Multiplies input1 to input2 and outputs the product.
        /// </returns>        
        public static int Multiply(int input1, int input2)
        {
            return input1 * input2;
        }

        /// <summary>
        /// This method divides the user inputed integers
        /// </summary>
        /// <param name="input1 - number 1-1000"></param>
        /// <param name="input2 - number 1-1000"></param>
        /// <returns>Divides input1 by input2 and outputs the quotient.
        /// </returns>
        public static double Divide(double input1, double input2)
        {

            return input1 / input2;
        }
    }
}