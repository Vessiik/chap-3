using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 36;
            bool divisible = number % 35 == 0 ? true : false;
            Console.WriteLine("{0} is divisible by both 5 and 7? {1}", number, "even");
        }
    }
}
