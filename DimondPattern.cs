using System;

class Pattern
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 5; i++)
        {
            for(int j = 5; j >= 1; j--)
            {
                if(i  >= j)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write(' ');
                }
            }
            Console.WriteLine();
        }
        
        for (int i = 4; i >= 1; i--)
        {
            Console.Write(' ');
            for (int j = 4; j >= 1; j--)
            {
                if (i >= j)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write(' ');
                }
            }
            Console.WriteLine();
        }

    }
}