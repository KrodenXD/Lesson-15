using System;

namespace Lesson_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            Console.WriteLine("Insert Weight");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert Country");
            string from = Convert.ToString(Console.ReadLine());
            order.MakeOrder(weight,from);
        }
    }
}
