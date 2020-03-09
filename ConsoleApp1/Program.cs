using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a13 = 4, b13 = 2, res13 = 0;
            res13 = Convert.ToInt32(Math.Pow((a13 - b13), 2));
            Console.WriteLine(res13);
        }
    }
}
