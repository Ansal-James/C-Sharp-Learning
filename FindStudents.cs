using System;
class findStudent
{
    static void Main(string[] ar)
    {
        var students = new Dictionary<int, string> { { 100, "daniyal" }, { 101, "abin" },{ 102, "achu" }, { 103, "abhi" },{ 104, "ansal" } };

        Console.Write("Enter student id : ");
        int id = Convert.ToInt32(Console.ReadLine());
        if (students.ContainsKey(id))
        {
            Console.WriteLine(students[id]);
        }
        else
        {
            Console.WriteLine("No User Data Found ! ");
        }
    }
}
