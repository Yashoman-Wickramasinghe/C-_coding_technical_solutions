using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseString
{
    public class ArraysAndArrayLists
    {
        public void AddValueToArray() {
            int[] nums = new int[3];
            nums[0] = 10;
            nums[1] = 20;
            nums[2] = 30;

            Console.WriteLine("The first element of the array is: " + nums[0]);
            //You cannot add a value to  fixed size array
            //below code will give an error.
            // nums[4] = 40;

            // Create an ArrayList (stores objects) 
            ArrayList arrayList = new ArrayList();

            // Adding elements of different types
            arrayList.Add(10);       // Integer
            arrayList.Add("Hello");  // String
            arrayList.Add(20.5);     // Double

            // Retrieving values with proper casting
            //int num = (int)arrayList[0];         //  Works because it's an int
            //string str = (string)arrayList[1];   //  Works because it's a string
            //double dbl = (double)arrayList[2];   //  Works because it's a double

            // Printing casted values
            //Console.WriteLine($"Integer: {num}");    // Output: Integer: 10
            //Console.WriteLine($"String: {str}");     // Output: String: Hello
            //Console.WriteLine($"Double: {dbl}");     // Output: Double: 20.5


            Console.WriteLine("The first element of the array is: " + arrayList[0]);
        }
    }
}
