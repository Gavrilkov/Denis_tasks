using System;

namespace Homework_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            IPalindromeService p = new PalindromeService();
            string r = null;
            do
            {
                try
                {
                    r = Console.ReadLine();
                    bool f = p.Check(r);
                    Console.WriteLine(f);
                }

                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while (r != "exit");
        }
    }
}
