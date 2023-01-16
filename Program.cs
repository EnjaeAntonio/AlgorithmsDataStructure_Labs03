// Had to delete and remake my git repo for this specific lab as I accidentally made my whole solution a git repo.
// Sorry if theres no pull requests

//We have a list of integers where elements appear either once or twice.
//Find the elements that appeared twice in O(n) time.
//example: { 1, 2, 3, 4, 7, 9, 2, 4}
//returns
//{ 2, 4}
Console.WriteLine("Finding elements that appear twice in a list");
List<int> intList = new List<int> { 1, 2, 3, 4, 7, 9, 2, 4 };
List<int> duplicateNumbers = new List<int>();
List<int> nonDuplicates = new List<int>();

for (int i = 0; i < intList.Count; i++)
{
    if (nonDuplicates.Contains(intList[i]) && !duplicateNumbers.Contains(intList[i]))
    {
        duplicateNumbers.Add(intList[i]); // Pushing/Adding duplicate numbers to List
    }
    else
    {
        nonDuplicates.Add(intList[i]); // Pushing/Adding the non duplicate numbers to another array
    }
}

string duplicatesString = string.Join(", ", duplicateNumbers.ToArray());
Console.WriteLine($"Duplicate numbers in the list are: {duplicatesString}");

string nonDuplicateString = string.Join(", ", nonDuplicates.ToArray());
Console.WriteLine($"Non-duplicate numbers are: {nonDuplicateString}");


//We have two sorted int arrays which could be with different sizes.
//We need to merge them in a third array while keeping this result array sorted.    
//Can you do that in O(n) time? Don't use any extra structures like Sets or Dictionaries
//example: { { 1, 2, 3, 4, 5}, { 2, 5, 7, 9, 13} }
//returns
//{ 1, 2, 2, 3, 4, 5, 5, 7, 9, 13}
Console.WriteLine();
Console.WriteLine("Merging two arrays into a third array, and keeping the values sorted");
int[] array1 = new int[] { 1, 2, 3, 4, 5 };
int[] array2 = new int[] { 2, 5, 7, 9, 13 };
int[] array3 = new int[array1.Length + array2.Length];
Array.Copy(array1, array3, array1.Length);
Array.Copy(array2, 0, array3, array1.Length, array2.Length);
Array.Sort(array3);

Console.Write("Method I found online, using the copy method: ");
foreach(int num in array3)
{
    Console.Write(num);
}

for (int i = 0; i < array1.Length; i++)
{
    array3[i] = array1[i];
}
for(int j = 0; j < array2.Length; j++)
{
    array3[array1.Length + j] = array2[j];
}

Array.Sort(array3);
string sortedArray = string.Join(", ", array3);
Console.WriteLine();
Console.WriteLine($"Merged sorted array (my method): {sortedArray}");

//Given an integer, reverse the digits of that integer, e. g. input is 3415,
//output is 5143. What is the time complexity of your solution?
Console.WriteLine();
Console.WriteLine("Enter an integer to be reversed");
int userInt = Int32.Parse(Console.ReadLine());
char[] chars = userInt.ToString().ToCharArray();
Array.Reverse(chars);
string reversedNum = string.Join("", chars);
Console.WriteLine($"Your number reversed is: {reversedNum}");
