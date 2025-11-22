using System;
using System.Numerics;
class FindAvg
{
    static void Main(string[] args)
    {
        int[] arr = { 1,2,3,4,5 };
        int[] revarr = new int[arr.Length];
        int j = 0;
        for(int i= arr.Length-1; i>=0; i-- )
        {
            revarr[j]=arr[i];
            j++;
        }
        Console.WriteLine("Reversed Array : ");
        foreach(int i in revarr)
        {
            Console.Write(i+" ");
        }
    }
}