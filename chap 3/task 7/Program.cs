using System;

namespace task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter weight of a human: ");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("This person will weight {0}kg on the Moon.", weight * 0.17);
        }
    }
}
