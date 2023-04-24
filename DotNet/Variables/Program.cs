int number = 1234;
string name = "John Doe";
int[] myArray = { 1, 2, 3 };
// List<int> myList = new() { 1, 2, 3 };

Console.WriteLine(number);
Console.WriteLine(name);
PrintArray(myArray);

Console.WriteLine("--------");
myArray.Append(4); // won't work!
// myList.Add(4);
PrintArray(myArray);

void PrintArray(int[] arrayToPrint)
{
    foreach (int value in arrayToPrint)
    {
        Console.Write(value + " ");
    }
    Console.WriteLine();
}