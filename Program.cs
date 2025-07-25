using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Activity_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            Console.Write("Enter position (0-based): ");
            if (!int.TryParse(Console.ReadLine(), out int pos))
            {
                Console.WriteLine("Invalid position");
                return;
            }
            if (pos < 0 || pos >= word?.Length)
            {
                Console.WriteLine("Position out of range");
            }
            else
            {
                Console.WriteLine($"Character at position {pos}: {word[pos]}");
            }
        }
    }
}
                
           
        


