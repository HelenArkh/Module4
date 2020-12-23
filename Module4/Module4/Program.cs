using System;

namespace Module4
{
    class Program
    {
        static void Main(string[] args)
        {
            var inv = true;
            var result = !inv;

            Console.WriteLine(result);
            Console.WriteLine();

            int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } }; 
            Console.WriteLine(array[0, 0]);

            foreach(var item in array)
            {
                Console.Write(item + " ");
            }

            Console.Write("Количество строк: ");
            Console.WriteLine(array.GetUpperBound(0) + 1 + " ");

            Console.Write("Количество колонок: ");
            Console.WriteLine(array.GetUpperBound(1) + 1 + " ");

            for (int i=0; i<array.GetUpperBound(0)+1; i++) 
            {
                for (int k=0; k<array.GetUpperBound(1) + 1; k++)
                {
                    Console.Write(array[i, k] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("А теперь выведем по колонкам:");

            for (int i=0; i<array.GetUpperBound(1) + 1; i++)
            {
                for(int k=0; k<array.GetUpperBound(0) + 1;k++)
                {
                    Console.Write(array[k, i] + " ");
                }
                Console.WriteLine();
            }

            //Sorting.SortingOneDimensionalArray();
            Sorting.ForceMassMass();

            //  SmallestElementOfAnArray.ReverseOrder();
            // SmallestElementOfAnArray.Name();

            // SmallestElementOfAnArray.WhichElementIsSmallest();

            // CountingTheSum.CountingTheSumOfPositiveNumbers();

           // FavoriteColor.MyFavoriteColorMassive();
            //FavoriteColor.MyFavoriteColorDoWhile();


            var a = 6;
            var b = 7;

            if (a == b)
            {
                Console.WriteLine("Условие истинно");
            }
            else if (b < 10)
            {
                    Console.WriteLine("Значение b = {0} меньше 10", b);
            }
            else
            {
                Console.WriteLine("Значение b = {0} больше 10", b);
            }


            }
        }
    }
