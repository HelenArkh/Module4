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

           // CountingTheSum.CountingTheSumOfPositiveNumbers();

            FavoriteColor.MyFavoriteColorMassive();
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
