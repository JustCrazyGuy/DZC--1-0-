using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZCsh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some text: ");
            char input;
            int spaceCount = 0;
            do
            {
                input = Console.ReadKey().KeyChar;
                if (input == ' ')
                    spaceCount++;
            }
            while (input != '.');

            Console.WriteLine("Spaces: " + spaceCount);
        }
        }
    }
