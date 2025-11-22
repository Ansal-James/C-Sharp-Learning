using System;
interface ITest1
{
    void add(int x, int y);
}
interface ITest2 : ITest1
{
    void sub(int x, int y);
}

public class Solution: ITest2
{
    public void add(int x, int y)
    {
        Console.WriteLine("Addition : {0}", x + y);
    }
    public void sub(int x, int y)
    {
        Console.WriteLine("Subtraction : {0}", x - y);
    }
}

public class MainClass
{
    static void Main(string[] args)
    {
        Solution s = new Solution();
        s.add(1, 2);
        s.sub(2, 3);
    }
}