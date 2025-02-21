using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseString
{
    public class NumberOfOcurrences
    {
        public void CountNumberOfOcurrences(string str) 
        {

            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (charCount.ContainsKey(c))
                    charCount[c]++;
                else
                    charCount[c] = 1;
            }

            // Display the character frequencies
            foreach (var pair in charCount)
            {
                Console.WriteLine($"Character '{pair.Key}': {pair.Value} times");
            }

        }
    }
}
