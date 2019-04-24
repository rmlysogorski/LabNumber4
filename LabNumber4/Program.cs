using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool end = false;

            while (!end)
            {
                Console.Clear();
                Console.WriteLine("Learn your squares and cubes!\n");
                Methods.GetSquaresAndCubes();
                end = Methods.EndProgram("\nContinue? (y/n): ", "y", "n");
            }

            Console.WriteLine("\nGood luck out there!\n");
        }
    }
}
