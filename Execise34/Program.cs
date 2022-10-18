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
    int[] result = array;
    int res = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = result[i] % 10;
    }
    
    for (int i = 0; i < result.Length; i++) 
    {
        if (result[i] == 0 || result[i] == 2 || result[i] == 4 || result[i] == 6 || result[i] == 8) res++;   
    }

return res;
}


int[] arr = CreateArrayRndInt(10, 100, 1000);
PrintArray (arr);
int countEvenNumbers = CountEvenNumbers (arr);
Console.WriteLine ($"Количество чётных чисел в данном массиве равно {countEvenNumbers}");
