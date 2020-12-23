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
        public static void Questionnaire443()
        {
            var (name, age) = ("Евгения", 27);

            Console.WriteLine("Ваше имя: {0}", name);
            Console.WriteLine("Ваш возраст: {0}", age);



            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your name is {0} and age is {1}", name, age);

        }
        public static void Pet()
        {
            (string name,string type,double age,int nameCount) Pet;



            Console.Write("Введите имя питомца: ");
            Pet.name = Console.ReadLine();

            Console.Write("Введите возраст: ");
            Pet.age = double.Parse(Console.ReadLine());

            Console.Write("Введите тип питомца: ");
            Pet.type = Console.ReadLine();

            Pet.nameCount = 0;
            foreach(var letter in Pet.name)
            {
                Pet.nameCount++;
            }

            //можно было сделать проще:
           // Pet.nameCount = Pet.name.Length;



            Console.WriteLine("Имя вашего питомца {0} и возраст {1}", Pet.name, Pet.age);
            Console.WriteLine("Что за питомец: {0}", Pet.type);
            Console.WriteLine("Длина имени питомца: {0}", Pet.nameCount);



        }
        public static void UserSurvey()
        {
            (string name, string surname, string login, int loginLength, bool hasPet, double age, string[] favColors) User;

            for (int k = 0; k < 3; k++)
            {

                Console.WriteLine("Введите имя");
                User.name = Console.ReadLine();

                Console.WriteLine("Введите фамилию");
                User.surname = Console.ReadLine();

                Console.WriteLine("Введите логин");
                User.login = Console.ReadLine();

                User.loginLength = User.login.Length;

                Console.WriteLine("Есть ли у Вас животные? Да или Нет");
                string answer = Console.ReadLine();

                if (answer == "Да")
                {
                    User.hasPet = true;
                }
                else
                {
                    User.hasPet = false;
                }

                Console.WriteLine("Введите возраст пользователя: ");
                User.age = double.Parse(Console.ReadLine());

                User.favColors = new string[3];
                Console.WriteLine("Введите 3 любимых цвета пользователя");
                for (int i = 0; i < User.favColors.Length; i++)
                {
                    User.favColors[i] = Console.ReadLine();
                }
            }
        }
    }
}
