using System;

namespace MethodExercise
{
    class Program
    {
        private static void Main(string[] args)
        {
            MyFavoriteThings();

            //Add(int.MinValue, int.MaxValue);
            Add(2, 2); // Calling the method (invoking the method)
        }


        // Declaring a method
        public static void Add(int num1, int num2)
        {
            int answer = num1 + num2;
            Console.WriteLine(answer);
        }

        public static void MyFavoriteThings()
        {
            Console.Write("What is your name?");
            string userName = Console.ReadLine();

            Console.Write("What is your favorite color?");
            string userFavoriteColor = Console.ReadLine();

            Console.Write("What is your favorite animal?");
            string userFavoriteAnimal = Console.ReadLine();

            Console.Write("What is your favorite band?");
            string userFavoriteBand = Console.ReadLine();

            Console.WriteLine($"There is a kid name {userName} who lost her sight at a very young age. But she " +
                $"she remembers her favorite color {userFavoriteColor}. She had many animals as her pets, but her favorite animal was {userFavoriteAnimal}." +
                $"She also loved all genres of music, but and her favorite band was {userFavoriteBand}");

        }
    }
}
