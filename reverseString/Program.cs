// See https://aka.ms/new-console-template for more information


using reverseString;

string[] message = { "hello" };

int[] num = { 1, 2, 3, 4, 5 };

Console.WriteLine(message[0] + " " +"world");

// count of the int array
Console.WriteLine("Length of the num array :" + num.Length);

//----------- sum of the int array-----------------------------------
int sum = 0;

for (int i = 0; i < num.Length; i++)
{
    //sum += num[i];
    sum = sum + num[i];
}

Console.WriteLine("Sum of the num array :" + sum);


//-------------------revers an string --------------------------------

//The reason we convert the string to a char[] (character array) using ToCharArray() is because strings in C# are immutable. 
//This means that once a string is created, it cannot be modified directly.
//A char[] (character array) is mutable, meaning we can modify it in-place (Eg:reversing it).
string input = "hello";

char[] charArray = input.ToCharArray();

Array.Reverse(charArray);

string reversed = new string(charArray); // Convert back to string

Console.WriteLine( "Using Char Array " + reversed);

//----------End -revers an string using string builder-------------------

//----------Start -revers using LINQ ------------------------------------

string input2 = "hello";

string reversed2 = new string(input2.Reverse().ToArray());

Console.WriteLine("Using LINQ " + reversed2);

//-----------------End--revers an string --------------------------------


//----------Start -Find Palindromewords ------------------------------------
Palindromewords palindromewords = new Palindromewords();

Console.WriteLine("Enter the string to check for palindrome :");

string userInput = Console.ReadLine();

palindromewords.checkPlaindrome(userInput);

//----------End -Find Palindromewords ------------------------------------

//----------Start -Reverse Sentence ------------------------------------
ReverseSentence rs = new ReverseSentence();

Console.WriteLine("Enter a sentence");

string userInput2 = Console.ReadLine();

rs.reverseSentence(userInput2);

//----------End -Reverse Sentence ------------------------------------