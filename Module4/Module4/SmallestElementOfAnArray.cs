using System;
using System.Collections.Generic;
using System.Text;

namespace Module4
{
    class SmallestElementOfAnArray
    {
        public static void WhichElementIsSmallest()
        {
            var numbers = new int[] { 6, 30, 7, 14, 2, 15 };
            int minValue = 100000,
            minIndex = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < minValue)
                {
                    minValue = numbers[i];
                    minIndex = i;
                }
            }

            Console.WriteLine("Наименьший элемент массива имеет индекс {0}, значение этого элемента = {1}", minIndex, numbers[minIndex]);

            Console.ReadKey();
        }

        public static void Name()
        {
            Console.WriteLine("Введите свое имя");

            var name = Console.ReadLine();

            Console.WriteLine("Ваше имя по буквам: ");

            foreach(var ch in name)
            {
                Console.Write(ch + " ");
            }
            Console.WriteLine("Последняя буква вашего имени: {0}", name[name.Length - 1]);

            Console.ReadKey();
        }
        public static void ReverseOrder()
        {
            Console.WriteLine("Введите свое имя");

            var name = Console.ReadLine();

            Console.WriteLine("Ваше имя по буквам в обратном порядке: ");

            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.Write(name[i] + " ");
            }
            Console.WriteLine("Первая буква вашего имени: {0}", name[0]);

            Console.ReadKey();
        }
    }
}
