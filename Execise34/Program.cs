// Задача 34: Задайте массив, заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int CountEvenNumbers(int[] array)
{
    int[] remainderDivision10 = array;
    int result = 0;

    for (int i = 0; i < array.Length; i++)
    {
        remainderDivision10[i] = remainderDivision10[i] % 10;
    }

    for (int i = 0; i < remainderDivision10.Length; i++)
    {
        if (remainderDivision10[i] == 0 || remainderDivision10[i] == 2 ||
            remainderDivision10[i] == 4 || remainderDivision10[i] == 6 ||
            remainderDivision10[i] == 8)
            result++;
    }

    return result;
}


int[] arr = CreateArrayRndInt(10, 100, 1000);
PrintArray(arr);
int countEvenNumbers = CountEvenNumbers(arr);
Console.WriteLine($"Количество чётных чисел в данном массиве равно {countEvenNumbers}");
