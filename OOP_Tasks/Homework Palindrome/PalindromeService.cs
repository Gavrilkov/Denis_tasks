using System;
using System.Collections.Generic;
using System.Text;


namespace Homework_Palindrome
{
    public class PalindromeService : IPalindromeService
    {
        public bool Check(string inputString)
        {
           string s = inputString.ToLower();
           string newInputString = s.Replace(" ", "");
            if (inputString.Length < 2)
            {
                throw new ArgumentException("The word must contain at least 2 letters");
            }
            char[] pol = new char[newInputString.Length];
            pol = newInputString.ToCharArray();
            char[] polrev = new char[pol.Length];
            polrev = newInputString.ToCharArray();
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