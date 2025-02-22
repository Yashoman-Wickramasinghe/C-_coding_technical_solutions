using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseString
{
    public class SortedLists
    {
        public void SortedListSample() { 
            
            SortedList <int, string> keyValuePairs = new SortedList<int, string>();

            keyValuePairs.Add(1, "Apple");
            keyValuePairs.Add(3, "Banana");
            keyValuePairs.Add(2, "Orange");

            Console.WriteLine("Sorted List :");

            foreach (var item in keyValuePairs) 
                Console.WriteLine($"{item.Key}: {item.Value}");

            Console.WriteLine("First Key: { keyValuePairs.Keys[0]}");
        }
    }
}
