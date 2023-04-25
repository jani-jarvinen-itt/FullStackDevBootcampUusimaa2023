// read user's input
Console.WriteLine("Please enter a string:");
string input = Console.ReadLine();

// method 1: reverse the input
/*
string reversed = "";
for (int index = input.Length - 1; index >= 0; index--)
{
    reversed += input[index];
}
Console.WriteLine(reversed);
*/

// method 2: reverse the input
char[] chars = input.ToCharArray();
Array.Reverse(chars);
string reversed = new string(chars);
Console.WriteLine(reversed);

// compare the input to the reversed string
bool isPalindrome = (input == reversed);

// display results
if (isPalindrome)
{
    Console.WriteLine("The input is a palindrome.");
}
else
{
    Console.WriteLine("The input is NOT a palindrome.");
}