// Basic Mathematical Operations
// Your task is to create a function that does four basic mathematical operations.

// The function should take three arguments - operation(string/char), value1(number), value2(number).
// The function should return result of numbers after applying the chosen operation.
// Examples(Operator, value1, value2) --> output

// ('+', 4, 7) --> 11
// ('-', 15, 18) --> -3
// ('*', 5, 5) --> 25
// ('/', 49, 7) --> 7


using System.Data;

Console.Write("Operation: ");
var operation = Console.ReadLine();
Console.Write("Value 1: ");
var value1 = int.Parse(Console.ReadLine());
Console.Write("Value 2: ");
var value2 = int.Parse(Console.ReadLine());

Console.WriteLine(basicOp2(operation[0], value1, value2));


static double basicOp(char operation, double value1, double value2)
{
    return operation switch
    {
        '+' => value1 + value2,
        '-' => value1 - value2,
        '*' => value1 * value2,
        '/' => value1 / value2
    };
}

static double basicOp2(char operation, double value1, double value2)
{
    return Convert.ToDouble(new DataTable().Compute($"{value1}{operation}{value2}", ""));
}