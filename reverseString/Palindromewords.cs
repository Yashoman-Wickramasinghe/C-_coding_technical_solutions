using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseString
{
    public class Palindromewords
    {
        public void checkPlaindrome(string str) 
        {
            string strLowerCase = new string(str.ToLower());

            string strReverse = new string(strLowerCase.Reverse().ToArray());

            if (strLowerCase.Equals(strReverse))
            {
                Console.WriteLine("The given string is a palindrome");
            }
            else
            {
                Console.WriteLine("The given string is not a palindrome");
            }
        }
    }
}
