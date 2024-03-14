// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 29
// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))



int ColculationOfTheAckermannFunccion(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    if (m == 0)
    {
        return ColculationOfTheAckermannFunccion(n - 1, 1);
    }
    else
    {
        return ColculationOfTheAckermannFunccion(n - 1, ColculationOfTheAckermannFunccion(n, m - 1));
    }
}

Console.WriteLine("Введите положительное число M: ");
if (int.TryParse(Console.ReadLine(), out int M) && M >= 0)
{
    Console.WriteLine("Введите положительное число N: ");
    if (int.TryParse(Console.ReadLine(), out int N) && N >= 0)
    {
        Console.Write($"M = {M}; N = {N} ->A (m,n) = {ColculationOfTheAckermannFunccion(N, M)}");
       ColculationOfTheAckermannFunccion(N, M);
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("Некоректный ввод, число M отрицательное.");
    }
}
else
{
    Console.WriteLine("Некоректный ввод, число N отрицательное.");
}