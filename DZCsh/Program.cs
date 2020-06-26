using System;
using System.Linq;


namespace DZCsh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number:  ");
            string str;
            int leftNumber = 0;
            int rightNumber = 0;
            while (true)
            {
                str = Console.ReadLine();
                char[] ch = new char[str.Length];
                ch = str.ToCharArray();
                int[] ticketNumber = ch.Select(s => int.Parse(s.ToString())).ToArray();
                for (int i = 0; i < ch.Length; i++)
                {
                    if (i < 3)
                    {
                        leftNumber += ticketNumber[i];
                    }

                    else rightNumber += ticketNumber[i];
                }
                if (ch.Length != 6)
                {
                    Console.WriteLine("Error numbers!Please try again!");
                }
                else if (leftNumber == rightNumber)
                {
                    Console.WriteLine("You lucky!!!", leftNumber, rightNumber);
                    break;
                }

                else if (leftNumber != rightNumber)
                {
                    Console.WriteLine("Not today.", leftNumber, rightNumber);
                    break;
                }
               
            }
        }
    }
}
