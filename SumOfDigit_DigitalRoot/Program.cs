using System;

namespace SumOfDigit_DigitalRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Digital root is the recursive sum of all the digits in a number.
            // Given n, take the sum of the digits of n. If that value has more than one digit,
            // continue reducing in this way until a single-digit number is produced.
            // The input will be a non-negative integer.\
            // Examples:
            // 16  -->  1 + 6 = 7
            // 942  -->  9 + 4 + 2 = 15  -->  1 + 5 = 6
            // 132189  -->  1 + 3 + 2 + 1 + 8 + 9 = 24  -->  2 + 4 = 6
            // 493193  -->  4 + 9 + 3 + 1 + 9 + 3 = 29  -->  2 + 9 = 11  -->  1 + 1 = 2

                long n;
                while (true)
                {
                    Console.Write("Введите число: ");
                    if (Int64.TryParse(Console.ReadLine(), out n))
                    {
                        Console.WriteLine($"Digital root number \"{n}\" is \t\t {DigitalRoot(n)}");
                    }
                    else
                    {
                        Console.WriteLine("Введенное значение не является числом!");
                    }
                }
        }

        /// <summary>
        /// My answer
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private static int DigitalRoot(long n)
        {
            int result = 0;
            foreach (var digit in n.ToString()) {
                result += Int32.Parse(digit.ToString());
            }

            if (result > 9)
                result = DigitalRoot(result); 

            return result;
        }
        
        /// <summary>
        /// Best answer
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int DigitalRootBest(long n)
        {
            return (int)(1 + (n - 1) % 9);
        }
        
        
        /// <summary>
        /// Also likes
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int DigitalRoot2st(long n)
        {
            if (n < 10) return (int)n;
            long r = 0;
            while (n > 0)
            {
                r += n % 10;
                n /= 10;
            }
            return DigitalRoot(r);
        }

        
    }
}