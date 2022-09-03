using System;
using System.Collections.Generic;
using System.Text;


namespace Homework_Palindrome
{
   public class PalindromeService: IPalindromeService
    {

        public  bool  Check (string inputString)
        {
            bool d = inputString.Contains(' ');
            if (d)
            {
                throw new ArgumentException("Enter a word without spaces");
            }
            char[] pol = new char[inputString.Length];
            pol = inputString.ToCharArray();
            char[] polrev = new char[pol.Length];
            polrev = inputString.ToCharArray();
            Array.Reverse(polrev);

                for (int i = 0; i < pol.Length; i++)
                {
                    if (pol[i] != polrev[i])
                        return false;
                }

            return true;
        }
    }
}