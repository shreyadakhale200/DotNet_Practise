// See https://aka.ms/new-console-template for more information
// Mutlidimensional array is also known as rectangulr arrayy in c#.
// It can be two dimensional or three dimensional array
// The data is stored in tabular form (row * column) which is also known as matrix

Console.WriteLine("Enter Row = ");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Column = ");
int column = Convert.ToInt32(Console.ReadLine());


int[,] arr = new int[row, column];
Console.Write("Length of the array is = ");
Console.Write(" " + arr.Length + "\n");
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        Console.Write("Enter number at position [" + i + ", " + j + "] = ");
        arr[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}


for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}

