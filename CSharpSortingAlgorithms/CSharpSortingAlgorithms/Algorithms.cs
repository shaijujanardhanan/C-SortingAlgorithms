using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSortingAlgorithms
{
    public static class Algorithms
    {
        public static int [] SelectionSort(int[] input)
        {
            for(int i = 0; i < input.Length; i++)
            {
                for(int j = i; j < input.Length; j++)
                {
                    if (input[i] > input[j])
                        swap(ref input[i], ref input[j]);
                }
            }
            return input;
        }

        public static int [] BubbleSort(int[] input)
        {
            for (int k = input.Length - 1, l = 0 ; k >= l; l++)
            {
                for (int i = k, j = i - 1; j >= 0; i--, j--)
                {
                    if (input[i] > input[j])
                        swap(ref input[i], ref input[j]);
                }

            }
            return input;
        }

        private static void swap(ref int input1, ref int input2)
        {
            int temp = input1;
            input1 = input2;
            input2 = temp;
        }

        public static void display(int [] input)
        {
           foreach(var x in input)
                Console.WriteLine($"element at {Array.IndexOf(input, x)} = {x}");
        }
    }

    
}
