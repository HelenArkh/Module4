using System;
using System.Collections.Generic;
using System.Text;

namespace Module4
{
    class Sorting
    {
        public static void SortingOneDimensionalArray()
        {
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

            int value;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {

                    if (arr[i] > arr[j])
                    {
                        value = arr[i];
                        arr[i] = arr[j];
                        arr[j] = value;
                    }
                }
            }
            foreach(var item in arr)
            {
                Console.Write(item + " ");
            }
        }

        public static void Sum()
        {
            var mass = new int[] { 5, 6, 9, 1, 2, 3, 4 };

            int sum = 0;
            foreach(var item in mass)
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }

        public static void ForceMassMass()
        {
            int[][] array = new int[3][];

            array[0] = new int[2] { 1, 2 };
            array[1] = new int[3] { 1, 2, 3 };
            array[2] = new int[5] { 1, 2, 3, 4, 5 };
            
            foreach(var num in array)
            {
                foreach(var item in num)
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}
