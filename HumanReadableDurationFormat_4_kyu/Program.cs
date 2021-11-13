using System;

namespace HumanReadableDurationFormat_4_kyu
{
    class Program
    {
        // Ваша задача для выполнения этого Ката - написать функцию, которая форматирует продолжительность,
        // заданную в виде количества секунд, удобным для человека способом.
        // Функция должна принимать неотрицательное целое число. Если он равен нулю, он просто возвращает "now".
        // В противном случае продолжительность выражается в виде комбинации лет, дней, часов, минут и секунд.
        // Например:
        // formatDuration (62)    // returns "1 minute and 2 seconds"
        // formatDuration (3662)  // returns "1 hour, 1 minute and 2 seconds"
        // Для целей этого Ката год составляет 365 дней, а день - 24 часа.
        // Подробные правила
        // Полученное выражение состоит из таких компонентов, как 4 секунды, 1 год и т.д.
        // В общем случае положительное целое число и одна из допустимых единиц времени, разделенных пробелом.
        // Единица измерения времени используется во множественном числе, если целое число больше 1.
        // Компоненты разделяются запятой и пробелом (","). За исключением последнего компонента, который разделен "and",
        // точно так же, как это было бы написано на английском языке.
        // Более значимые единицы времени произойдут раньше, чем наименее значимые.
        // Следовательно, 1 секунда и 1 год неверны, но 1 год и 1 секунда верны.
        // Разные компоненты имеют разную единицу измерения времени.
        // Таким образом, нет повторяющихся единиц измерения, таких как 5 секунд и 1 секунда.
        // Компонент вообще не появится, если его значение окажется равным нулю.
        // Следовательно, 1 минута и 0 секунд недопустимы, но это должно быть всего 1 минута.
        // Единицу времени необходимо использовать "как можно больше".
        // Это означает, что функция должна возвращать не 61 секунду, а 1 минуту и 1 секунду вместо этого.
        // Формально продолжительность, указанная компонентом, не должна превышать любую допустимую более значительную единицу времени.
        
        // Assert.AreEqual("now",HumanTimeFormat.formatDuration(0));
        // Assert.AreEqual("1 second",HumanTimeFormat.formatDuration(1));
        // Assert.AreEqual("1 minute and 2 seconds",HumanTimeFormat.formatDuration(62));
        // Assert.AreEqual("2 minutes",HumanTimeFormat.formatDuration(120));
        // Assert.AreEqual("1 hour, 1 minute and 2 seconds",HumanTimeFormat.formatDuration(3662));
        // Assert.AreEqual("182 days, 1 hour, 44 minutes and 40 seconds",HumanTimeFormat.formatDuration(15731080));
        // Assert.AreEqual("4 years, 68 days, 3 hours and 4 minutes",HumanTimeFormat.formatDuration(132030240));
        // Assert.AreEqual("6 years, 192 days, 13 hours, 3 minutes and 54 seconds",HumanTimeFormat.formatDuration(205851834));
        // Assert.AreEqual("8 years, 12 days, 13 hours, 41 minutes and 1 second",HumanTimeFormat.formatDuration(253374061));
        // Assert.AreEqual("7 years, 246 days, 15 hours, 32 minutes and 54 seconds",HumanTimeFormat.formatDuration(242062374));
        // Assert.AreEqual("3 years, 85 days, 1 hour, 9 minutes and 26 seconds",HumanTimeFormat.formatDuration(101956166));
        // Assert.AreEqual("1 year, 19 days, 18 hours, 19 minutes and 46 seconds",HumanTimeFormat.formatDuration(33243586));
            
        static void Main(string[] args)
        {
            int s;
            while (true)
            {
                Console.Write("Введите кол-во секунд: ");
                if (Int32.TryParse(Console.ReadLine(), out s))
                {
                    Console.WriteLine($"Seconds \"{s}\" is \t\t {formatDuration(s)}");
                }
                else
                {
                    Console.WriteLine("Введенное значение не является числом!");
                }
            }
        }
        
        public static string formatDuration(int seconds)
        {
            //Enter Code here
            return "now";
        }
    }
}