using System;

namespace _23.calculationSumOfNumberdigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number num = ");
            
            var num = int.Parse(Console.ReadLine());
            Console.Write("sum of digits of the entered number = ");
            int sum = 0;

            do
            {
                sum += num % 10; //We sum -we take in this way only the last digit of the entered number;
                num = num / 10; //we assign the whole number by devision of 10, here we remove the reminder of n by divinding of 10;
                //We dont need  it any momore becasue we have once added it into the sum / exmple 5634 - > 563 - > 56 - >5-> 6 ;


            } while (num > 0);
            Console.WriteLine($"{sum}");

        }
    }
}
