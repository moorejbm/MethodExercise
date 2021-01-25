using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------------Exercise 1 
            // Name: Michael
            // Favorite Color: Blue
            // Favorite Animal: Walrus
            // Favorite Band: The Beatles

            Console.WriteLine(" Hello what is your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName}. What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($" {color} is an awsom color! What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("Great! Now, what is your favorite band?");
            var band = Console.ReadLine();
        }
    }
}
