using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double total = num * 7.61;
            double discount = total * 0.18;
            Console.WriteLine($"The final price is: {total - discount} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
