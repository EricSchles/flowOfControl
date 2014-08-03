using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flowOfControl
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.WriteLine("Please enter a number between 0 and 10:");
            number = int.Parse(Console.ReadLine());

            if (number < 0 || number > 10)
            {
                Console.WriteLine("You entered an invalid number, please run the program again and enter a number between 0 and 10");
            }
            else
            {
            
                Console.WriteLine("Good job");
            }

            Console.ReadLine();
        }
    }
}
