using System;

namespace MethodExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            string band = Console.ReadLine();

            Console.WriteLine($"There was a boy named {name} and his favorite color was {color}. \n" +
                $"{name} loved {animal} so much he adopted devoted his life to raising them on his farm. \n" +
                $"{name} trained every {animal} to play an instrument and started a band named {band} after his favorite band") ;
        }

        public static int Add(int num1, int num2)
        {
         return num1 + num2;    
        }
        public static int Subtract(int x, int y)
        {
            return x - y;   
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static int Divide(int c, int d)
        {
            return c - d;
        }
        public static int Modulus(int x, int y)
        {
            return (x * y) % y; 
        }



    }
}
