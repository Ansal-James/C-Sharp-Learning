using System;
using System.Numerics;
class FindAvg
{
    static void Main(string[] args)
    {
        int[] arr = { 34, 66, 44, 8, 9, 10, 28, 66, 20, 54 };
        int big = arr[0], small = arr[0];
        for(int i  = 0; i < arr.Length; i++)
        {
            if (arr[i] >= big)
            {
                big = arr[i];
            }

            if (arr[i] <= small)
            {
                small = arr[i];
            }
        }
        Console.WriteLine("Biggest Number is : {0}", big);
        Console.WriteLine("Smallest Number is : {0}", small);
    }
}