using System;

namespace Methodexercise2
{
    class Program
    {
        public static int Sum1(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }

        public static int Sum2(int num1, int num2)
        {
            var answer = num1 * num2;
            return answer;
        }

        public static int Sum3(int num1, int num2)
        {
            return  num1 / num2;
            
        }

        public static int Sum4(int num1, int num2)
        {
            return num1 - num2;

        }

        public static int Sum5(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;

        }

        public static int Sum6(int num1, int num2, int num3)
        {
            return num1 * num2 - num3;

        }

        public static int Sum7(int num1, int num2, int num3)
        {
            return num1 * num2 / num3;

        }


        static void Main(string[] args)
        {


                var amountOfCars = Sum1(2, 6);
                
                var canGoods = Sum2(3, 2);

                var shelfs = Sum3(28, 4);

                var cupboards = Sum4(33, 28);

                var closets = Sum5(1, 1, 1);

                var stairs = Sum6(2, 5, 10);

                var phone = Sum7(30, 3, 10);
            Console.WriteLine($"{amountOfCars}");
            Console.WriteLine($"{canGoods}");
            Console.WriteLine($"{shelfs}");
            Console.WriteLine($"{cupboards}");
            Console.WriteLine($"{closets}");
            Console.WriteLine($"{stairs}");
            Console.WriteLine($"{phone}");


                
        }
    }
}
