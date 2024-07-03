// See https://aka.ms/new-console-template for more information
int[] arr = new int[5] { 1, 2, 3, 4, 5 };
foreach (int i in arr)
{
    Console.WriteLine(i);
}

Array.Sort(arr);
Console.WriteLine("\nSort array");
foreach (int i in arr)
{
    Console.WriteLine(i);
}
Console.WriteLine("\nReverse array");
Array.Reverse(arr);
foreach (int i in arr)
{
    Console.WriteLine(i);
}

