﻿using System;

namespace MethodExercise
{
    class Program
    { 
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }

        public static int Multiply(int num3, int num4, int num5)
        {
            return num3 * num4 * num5;
        }
        static void Main(string[] args)
        {
            var amountOfCars = Sum(2, 6);
            //var blah = Multiply(60, 2, 4);

            //---------------------Exercise 1 
            // Name: Michael
            // Favorite Color: Blue
            // Favorite Animal: Walrus
            // Favorite Band: The Beatles

            Console.WriteLine("Hello what is your first name?");
            var username = Console.ReadLine();

            Console.WriteLine($"Hi, {username}. What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($" {color} is an awsom color! What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("Great! Now, what is your favorite band?");
            var band = Console.ReadLine();
            Console.WriteLine('\n');
            Console.WriteLine($"Thanks, {username}!  Here is your profile");
            
            Console.WriteLine("__________________________________");

            Console.WriteLine($"Name: {username}");
            Console.WriteLine($"Favorite Anamal: {color}");
            Console.WriteLine($"Favorite Collor: {animal}");
            Console.WriteLine($"Favorite Band: {band}");

            Console.WriteLine('\n');
            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is: {sum}");

            Console.WriteLine('\n');
            Console.WriteLine("Give me a number to multiply");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to multiply to the first one");
            int num4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to multiply to the second one");
            int num5  = int.Parse(Console.ReadLine());

            int multiply = Multiply(num3, num4, num5);
            Console.WriteLine($"The total is: {multiply}");

        }


            //---------------------Exercise 2



        }
    }

