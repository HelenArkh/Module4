using System;
using System.Collections.Generic;
using System.Text;

namespace Module4
{
    class UserProfileWithCortege
    {
        public static void Questionnaire()
        {
            (string name, int age) anketa;

            Console.Write("Enter your name: ");
            anketa.name = Console.ReadLine();

            Console.Write("Enter your age: ");
            anketa.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your name is {0} and age is {1}", anketa.name, anketa.age);

            Console.Write("Enter your birthdate: ");
            var birthdate = Console.ReadLine();

            Console.WriteLine("Your birthdate is {0}", birthdate);

        }
    }
}
