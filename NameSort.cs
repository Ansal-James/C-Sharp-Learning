using System;
using System.Collections.Generic;
class NameSort
{
    static void Main(string[] args)
    {
        Console.Write("Enter Five Names : ");
        List<string> names = new List<string>();
        for(int i = 0; i < 5; i++)
        {
            names.Add(Console.ReadLine());
        }
        names.Sort();
        Console.WriteLine("Sorted Names are : ");
        foreach(string name in names)
        {
            Console.WriteLine(name);
        }

    }
}
