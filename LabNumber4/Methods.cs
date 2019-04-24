using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber4
{
    class Methods
    {
        public static void GetSquaresAndCubes()
        {
            int userInt = GetUserInt("Enter an integer: ");
            PrintHeader();
            PrintSquaresAndCubes(userInt);

        }

        public static int GetUserInt(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();

            if (int.TryParse(input, out int userInt))
            {
                return userInt;
            }
            else
            {
                Console.WriteLine("Please enter a valid integer.");
                return GetUserInt(message);
            }
        }

        public static void PrintHeader()
        {
            Console.WriteLine("\nNumber\tSquared\tCubed");
            Console.WriteLine("======\t=======\t=====");
        }

        public static void PrintSquaresAndCubes(int userInt)
        {
            for (int i = 1; i <= userInt; i++)
            {
                Console.WriteLine($"{i}\t{i * i}\t{i * i * i}");
            }
        }

        public static bool EndProgram(string message, string option1, string option2)
        {
            Console.Write(message);
            string input = Console.ReadLine();

            if (input == option1)
            {
                return false;
            }
            else if (input == option2)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Please enter 'y' for yes and 'n' for no.");
                return EndProgram(message, option1, option2);
            }
        }
    }
}
