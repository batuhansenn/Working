using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "Engin";
            students[1] = "Batuhan";
            students[2] = "Büşra";

            string[] students2 = { "Engin", "Batuhan", "Büşra" };

            foreach (var student in students2)
            {
                Console.WriteLine(student );
            }
        }
    }
}
