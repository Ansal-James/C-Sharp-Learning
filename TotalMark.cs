using System;
class PrintDiagonal
{
    static void Main(String[] args)
    {
        int[,] arr = new int[3, 3] { { 45,55,65 }, { 70,60,80 }, { 90,85,75 } };
        int totalmark=0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                totalmark += arr[i, j];
            }
            Console.WriteLine($"Total of Student {i+1} : {totalmark}");
            totalmark = 0;
        }
    }
}