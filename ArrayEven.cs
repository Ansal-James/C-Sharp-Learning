using System;
class ArrayEven
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        foreach(int i in arr)
        {
            if (i % 2 == 0)
                Console.WriteLine(i);
        }
    }
}