// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write($"{array[i]}");
        }
        else
        {
            Console.Write($"{array[i]}, ");
        }
    }
    Console.Write("]");
}


void PrintReverseArray(int[] array, int count)
{
    if (count == 0) return;

    Console.Write($"{array[count - 1]} ");
    PrintReverseArray(array, count - 1);
}

int minmum = 1;
int maxmum = 100;

Console.WriteLine("Введите размер массива");
int count = Convert.ToInt32(Console.ReadLine());

int[] arrayNew = CreateArrayRndInt(count, minmum, maxmum);
PrintArray(arrayNew);
Console.Write(" => ");
PrintReverseArray(arrayNew, arrayNew.Length);
Console.WriteLine();