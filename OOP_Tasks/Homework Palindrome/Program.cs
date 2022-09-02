using System;

namespace Homework_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            PalindromeService p = new PalindromeService();
            bool f = p.Check(Console.ReadLine());
            Console.WriteLine(f);
        }
        
    }
}
