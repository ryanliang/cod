using System;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoSum(new int[]{1,2,3}, 3);
            TwoSum(new int[]{1,2,3,4}, 5);
            TwoSum(new int[]{1,2,7,4}, 11);
            TwoSum(new int[]{3,3}, 6);
        }

        public static int[] TwoSum(int[] input, int target)
        {
            var result = new int[2];
            for(int i = 0; i < input.Length - 1; i++)
            {
                for(int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] + input[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                        break;
                    }
                }
            }

            Console.WriteLine($"Result is {result[0]} and {result[1]}");

            return result;
        }
    }
}
