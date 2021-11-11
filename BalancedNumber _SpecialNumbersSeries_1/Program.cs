using System;
using System.Collections.Generic;
using System.Linq;

namespace BalancedNumber__SpecialNumbersSeries_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definition
            // Balanced number is the number that * The sum of all digits to the left of the middle digit(s)
            // and the sum of all digits to the right of the middle digit(s) are equal*.
            // [TestCase(7, "Balanced")]
            // [TestCase(959, "Balanced")]
            // [TestCase(13, "Balanced")]
            // [TestCase(56239814, "Balanced")]
            // [TestCase(424, "Balanced")]
            // [TestCase(1024, "Not Balanced")]
            // [TestCase(66545, "Not Balanced")]
            // [TestCase(295591, "Not Balanced")]
            // [TestCase(1230987, "Not Balanced")]
            // [TestCase(432, "Not Balanced")]
            
            int n;
            
            while (true)
            {
                Console.Write("Введите число: ");
                if (Int32.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine($"Number \"{n}\" is \t\t {IsBalansed(n)}");
                }
                else
                {
                    Console.WriteLine("Введенное значение не является числом!");
                }
            }
        }

        /// <summary>
        /// Определение сбаласированно ли число
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private static string IsBalansed(int n)
        {
            const string yes = "Balanced";
            const string not = "Not Balanced";

            if(n < 99) return yes;
            List<int> numbers = new List<int>();
            while (n > 0)
            {
                numbers.Add(n % 10);
                n /= 10;
            }
            
            int left=0, right=0;
            int mid = numbers.Count / 2 + numbers.Count % 2;
            
            for (int i = 1; i < mid; i++)
            {
                left += numbers[i-1];
                right += numbers[^i];
            }

            if (left == right) return yes;
            
            return not;
        }
        
        /// <summary>
        /// Best answer
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static string BalancedNumberBest(int number)
        {
            double middle = number.ToString().Length / 2.0;
            var leftSum = number.ToString().Take((int)Math.Ceiling(middle - 1)).Sum(x => x);
            var rightSum = number.ToString().Skip((int)++middle).Sum(x => x);
            return leftSum == rightSum ? "Balanced" : "Not Balanced";
        }
        
        
        /// <summary>
        /// Also likes
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static string BalancedNumber2st(int n)
        {
            return $"{n}".Take(($"{n}".Length + 1) / 2 - 1).Sum(c => c) == $"{n}".Skip($"{n}".Length / 2 + 1).Sum(c => c)
                ? "Balanced"
                : "Not Balanced";
        }
        
        
    }
}