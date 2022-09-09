// Summation
// Write a program that finds the summation of every number from 1 to num.
// The number will always be a positive integer greater than 0.

// For example:

// summation(2) -> 3
// 1 + 2

// summation(8) -> 36
// 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8


using System.Threading.Channels;

var num = int.Parse(Console.ReadLine());
var res = 0;
for (int i = 1; i <= num; i++)
{
    res += i;
}

Console.WriteLine(res);

Console.WriteLine(Summation(int.Parse(Console.ReadLine())));



int Summation(int num)
{
    if(num>1)
        return num + Summation(num - 1);
    return 1;
}

int SummationBest(int num)
{
    return num*(num+1)/2;
}

int SummationBest2(int num)
{
    return Enumerable.Range(1, num).Sum();
}