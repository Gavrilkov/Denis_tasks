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
            char[] polrev = new char[newInputString.Length];
            polrev = newInputString.ToCharArray();
            Array.Reverse(polrev);
            string ns = new string(polrev);
            if (ns == newInputString)
                return true;
            else
                return false;
        }
    }
}