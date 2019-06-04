using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        public static int ValidInput(string EdgeofTriangle)
        {

            int edge = 1;
            bool isValid = false;

            while (isValid == false)
            {

                Console.WriteLine("Please enter the {0} of your Triangle :", EdgeofTriangle);
                string userInput = Console.ReadLine();
                Console.WriteLine();

                bool result = int.TryParse(userInput, out edge);

                if (result == false)
                {
                    Console.WriteLine("Please enter a valid input");
                }
                else if (edge <= 0)
                {
                    Console.WriteLine("Please enter an integer greater than 0");
                }
                else
                {
                    isValid = true;
                    Console.WriteLine("{0} value is {1} for your triangle.",EdgeofTriangle,edge);
                }
            }
            return edge;
        }
        static void Main(string[] args)
        {
            bool validInput = false;
            string inputString;
           
            while (validInput == false)
            {
                do
                {
                    Console.WriteLine("Please choose the number from given below.");
                    Console.WriteLine("1. Enter the triangle Dimensions.");
                    Console.WriteLine("2. Exit");
                    inputString = Console.ReadLine();
                    Console.WriteLine(); ;

                    if (inputString != "1" && inputString != "2")
                    {
                        Console.WriteLine("That is not a valid selection");
                    }
                    else if (int.Parse(inputString) == 1)
                    {
                        validInput = true;
                        int Edge1;
                        int Edge2;
                        int Edge3;

                        Edge1 = ValidInput("Edge1");

                        Edge2 = ValidInput("Edge2");

                        Edge3 = ValidInput("Edge3");

                        Console.WriteLine(TriangleSolver.Analyze(Edge1, Edge2, Edge3));
                        Console.WriteLine();
                        
                    }
                    else if (int.Parse(inputString) == 2)
                    {
                        validInput = true; 
                    }
                } while (inputString != "2");

            }
        }
    }
}
