using System;
using System.Collections.Generic;
using System.Linq;

namespace LargestSiblings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert a integer to found its largest sibling:");
            string input = Console.ReadLine();
            int n = 0;

            if (int.TryParse(input, out n))
            {
                Console.WriteLine($"Largest sibling: {CalculteLargestSibling(n)}");
            }
            else
            {
                Console.WriteLine("Input isn't a valid integer");
            }

            Console.ReadKey();
        }

        public static int CalculteLargestSibling(int n)
        {
            // Convert to list of chars
            IList<char> numbers = n.ToString().ToList();

            // Sort from greather to lower
            numbers = numbers.OrderByDescending(c => c).ToList();

            // Join the sorted list and convert to long to avoid overflow if it became more than 2147483647
            long largestSibling = long.Parse(string.Join("", numbers));

            // Verify if it greather than 100.000.000
            if (largestSibling > 100000000)
                return -1;

            return (int)largestSibling;
        }
    }
}
