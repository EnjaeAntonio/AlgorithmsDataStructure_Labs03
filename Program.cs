//We have a list of integers where elements appear either once or twice.
//Find the elements that appeared twice in O(n) time.
//example: { 1, 2, 3, 4, 7, 9, 2, 4}
//returns
//{ 2, 4}

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
int[] array1 = new int[] { 1, 2, 3, 4, 5 };
int[] array2 = new int[] { 2, 5, 7, 9, 13 };
int[] array3 = new int[array1.Length + array2.Length];

for(int i = 0; i < array1.Length; i++)
{
    array3[i] = array1[i];
}
for(int j = 0; j < array2.Length; j++)
{
    array3[array1.Length + j] = array2[j];
}

Array.Sort(array3);
string sortedArray = string.Join(", ", array3);
Console.WriteLine($"Merged sorted array: {sortedArray}");

//Given an integer, reverse the digits of that integer, e. g. input is 3415,
//output is 5143. What is the time complexity of your solution?

Console.WriteLine("Enter an integer to be reversed");
int userInt = Int32.Parse(Console.ReadLine());
char[] chars = userInt.ToString().ToCharArray();
Array.Reverse(chars);
string reversedNum = string.Join("", chars);
Console.WriteLine($"Your number reversed is: {reversedNum}");
