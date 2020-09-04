using System;
using System.Linq;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new int[] { 1, 0, 4, 5, 0, 4, 5, 3, 0 };

            // first approach

            var iterations1 = 0;
            var array = data.ToArray();

            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                ++iterations1;
                if (array[i] != 0)
                {
                    array[j++] = array[i];
                }
            }

            while (j < array.Length)
            {
                ++iterations1;
                array[j++] = 0;
            }

            Console.WriteLine($"1. Approach (keeping the same items order): '{string.Join(",", array)}'");
            Console.WriteLine($"Time complexity: O({iterations1})");
            Console.WriteLine(Environment.NewLine);

            // second approach

            var iterations2 = 0;

            array = data.ToArray();

            var end = array.Length - 1;
            var index = end;
            for (int i = end; i >= 0; i--)
            {
                ++iterations2;
                if (array[i] == 0)
                {
                    var left = array[index];
                    var right = array[i];

                    array[i] = left;
                    array[index--] = right;
                }
            }

            Console.WriteLine($"2. Approach (changing items order): '{string.Join(",", array)}'");
            Console.WriteLine($"Time complexity: O({iterations2})");
            Console.ReadLine();
        }
    }
}
