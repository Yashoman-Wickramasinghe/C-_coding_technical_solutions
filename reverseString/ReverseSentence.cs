using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseString
{
    public class ReverseSentence
    {
        public void reverseSentence(string str)
        {
            string[] words = str.Split(' ');

            List<string> reversedWords = new List<string>();

            foreach (string word in words) {

                char[] charArray = word.ToCharArray();

                Array.Reverse(charArray);

                reversedWords.Add(new string(charArray));
            }

            // Join reversed words into a sentence
            string reversedSentence = string.Join(" ", reversedWords);

            Console.WriteLine("Reversed sentence: " + reversedSentence);

            //-- Reverse the wording and the words of the sentence

            for (int i = reversedWords.Count; i > 0; i--)
            {
                Console.Write(reversedWords[i - 1] + " ");
            }

        }
    }
}
