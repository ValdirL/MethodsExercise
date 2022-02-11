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
                $"{name} loved {animal} so much he devoted his life to raising them on his farm. \n" +
                $"{name} trained every {animal} to play an instrument and started a band named {band} after his favorite band") ;

            int sum = Add(2, 4);
            int sum2 = Subtract(10 , 5);
           int product = Multiply(3 , 3);
            int product2 = Divide(9 , 3);  
            int mod = Modulus(10 , 3);

            Console.WriteLine($"the sum of 2 + 4 is {sum}, the sum of 10 - 5 is {sum2}. The product of 3 * 3 is {product}, the product of 9 divided by 3 is {product2}. The remainder of 10 divided by 3 is {mod}  ");
      
       

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
            return c / d;
        }
        public static int Modulus(int x, int y)
        {
            return x % y; 
        }
        
  


    }
}
