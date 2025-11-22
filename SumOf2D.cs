using System;
using System.Numerics;
class FindAvg
{
    static void Main(string[] args)
    {
        int[,] arr = new int[2,3]{ { 1, 2, 3 },{ 4, 5, 6 } };
        int sum = 0;
        for (int i = 0; i <= arr.GetLength(0)-1; i++)
        {
            for (int j = 0; j <= arr.GetLength(1)-1; j++)
            {
                sum += arr[i,j];
            }
        }
        Console.WriteLine("Sum of the Array : {0}", sum);
    }
}