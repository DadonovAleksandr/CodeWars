// Roman Numerals Encoder
// Create a function taking a positive integer as its parameter and returning a string containing the Roman Numeral representation of that integer.
// Modern Roman numerals are written by expressing each digit separately starting with the left most digit and skipping any digit with a value of zero.
// In Roman numerals 1990 is rendered: 1000=M, 900=CM, 90=XC; resulting in MCMXC. 2008 is written as 2000=MM, 8=VIII; or MMVIII. 1666 uses each Roman symbol in descending order: MDCLXVI.

// Example:
// RomanConvert.Solution(1000) -- should return "M"

// Help:
//      Symbol    Value
//      I          1
//      V          5
//      X          10
//      L          50
//      C          100
//      D          500
//      M          1,000

// Remember that there can't be more than 3 identical symbols in a row.
// More about roman numerals - http://en.wikipedia.org/wiki/Roman_numerals

// Меньшая цифра может быть записана и слева от большей, тогда её следует вычесть из большей.
// При этом вычитаться могут только цифры, обозначающие 1 или степени 10,
// а в качестве уменьшаемого выступать только ближайшие в числовом ряду к вычитаемой две цифры
// (то есть вычитаемое, умноженное на 5 или 10). Повторения меньшей цифры не допускаются.
// Таким образом, существует только шесть вариантов использования «правила вычитания»:
// IV = 4
// IX = 9
// XL = 40
// XC = 90
// CD = 400
// CM = 900

var num = int.Parse(Console.ReadLine());
Console.WriteLine(Solution(num));
Console.ReadLine();

static string Solution(int n)
{
    if (n >= 1000) return "M" + Solution(n - 1000);
    if (n >= 900) return "CM" + Solution(n - 900);
    if (n >= 500) return "D" + Solution(n - 500);
    if (n >= 400) return "CD" + Solution(n - 400);
    if (n >= 100) return "C" + Solution(n - 100);
    if (n >= 90) return "XC" + Solution(n - 90);
    if (n >= 50) return "L" + Solution(n - 50);
    if (n >= 40) return "XL" + Solution(n - 40);
    if (n >= 10) return "X" + Solution(n - 10);
    if (n >= 9) return "IX" + Solution(n - 9);
    if (n >= 5) return "V" + Solution(n - 5);
    if (n >= 4) return "IV" + Solution(n - 4);
    if (n >= 1) return "I" + Solution(n - 1);
    return "";
}