// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.
// M = 1; N = 5 -> ,"1, 2, 3, 4, 5"
// M = 4; N = 8 -> ,"4, 5, 6, 7, 8"

void NaturalNumbers(int num1, int num2)
{
    if (num1 == num2)
    {
        if (num2 >= 0) Console.Write($"{num2}");
    }
    else
    {
        if (num1 < num2)
        {
            NaturalNumbers(num1, num2 - 1);
            if (num2 >= 0) Console.Write($", {num2}");
        }
        else if (num1 > num2)
        {
            if (num2 >= 0) Console.Write($"{num1}, ");
            NaturalNumbers(num1 - 1, num2);

        }
    }
}

Console.WriteLine("Введите натуральное число M: ");
if (int.TryParse(Console.ReadLine(), out int M) && M > 0)
{
    Console.WriteLine("Введите натуральное число N: ");
    if (int.TryParse(Console.ReadLine(), out int N) && N > 0)
    {
        Console.Write($"M = {M}; N = {N} -> \"");
        NaturalNumbers(M, N);
        Console.WriteLine("\"");
    }
    else
    {
        Console.WriteLine("Не коректный ввод, число M ненатуральное.");
    }
}
else
{
    Console.WriteLine("Не коректный ввод, число N ненатуральное.");
}