using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14
{
    class Program
    {
        static void Main(string[] args)
        {
            String userEntryOne;
            Console.Write("Enter a number: ");
            userEntryOne = Console.ReadLine();

            bool firstNumberValidation = int.TryParse(userEntryOne, out int firstNumber);

            for (int i = 1; i <= firstNumber; i++)
            {
                int iSquared = i * i;
                Console.WriteLine($"Your number is: {iSquared}" );
                if(i >= firstNumber)
                {
                    Console.Write("Would you like to continue (y/n): ");
                    string  newAnswer = Console.ReadLine();
                    if (newAnswer.Equals("y",StringComparison.OrdinalIgnoreCase)) 
                    {
                        Console.Write("Enter a number: ");
                        userEntryOne = Console.ReadLine();
                        int.TryParse(userEntryOne, out firstNumber);
                        i = 0;
                        continue;
                    }
                    else if (newAnswer.Equals("n", StringComparison.OrdinalIgnoreCase))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Value entered was not y or n!");
                        break;
                    }
                }
            }

            Console.WriteLine("Good Bye!!!");          
            Console.ReadKey();

            
        }
    }
}
