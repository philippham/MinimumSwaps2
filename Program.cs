using System;

namespace MinimumSwaps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(minimumSwaps(new int[] { 7, 1, 3, 2, 4, 5, 6 }));
        }

        static int minimumSwaps(int[] arr)
        {
            int sumSwaps = 0;
            if (arr.Length == 1)
            {
                return sumSwaps;
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                while (i != arr[i] - 1)
                {
                    int temp = arr[i];
                    arr[i] = arr[arr[i] - 1];
                    arr[temp - 1] = temp;
                    sumSwaps++;
                }
            }

            return sumSwaps;
        }
    }
}
