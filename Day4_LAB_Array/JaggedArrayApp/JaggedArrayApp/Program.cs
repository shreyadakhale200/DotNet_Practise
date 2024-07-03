// See https://aka.ms/new-console-template for more information
int[][] arr = new int[3][]
{
    new int[] { 1,3,4,5},
    new int[] { 1,3,43,32,5},
    new int[] { 1,3,4,6,76}
};

for (int i = 0; i < arr.Length; i++)
{
    for (int j = 0; j < arr[i].Length; j++)
    {
        Console.Write(arr[i][j] + " ");
    }
    Console.WriteLine();
}