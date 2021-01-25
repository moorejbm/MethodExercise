using System;

namespace MethodExercise
{
    class Program
    { 
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }

        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }
        static void Main(string[] args)
        { 
            var amountOfCars = Sum(2, 6);
            var blah = Multiply(60, 2, 4);
       
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

            Console.WriteLine($"Thanks, {userName}!  Here is your profile");
            Console.WriteLine("__________________________________");

            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Favorite Anamal: {color}");
            Console.WriteLine($"Favorite Collor: {animal}");
            Console.WriteLine($"Favorite Band: {band}");

            //---------------------Exercise 2



        }
    }
}
