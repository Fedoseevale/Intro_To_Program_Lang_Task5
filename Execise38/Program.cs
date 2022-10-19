// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndInt(int size, int min, int max)
{
    double[] array = new double[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round((rnd.NextDouble() * (max - min) + min), 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}; "); //для лучшей читаемости элементы массива разделены не ",", а ";"
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double DifferenceMaxMinElements(double[] array) // метод для вычисления разницы между максимальным и минимальным элементами массива
{

    double MaxElements(double[] array) // подметод для вычисления максимального элемента массива
    {
        int i = 0;
        double[] maxArr = array;
        maxArr[i] = 0;
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] > maxArr[i]) maxArr[i] = array[j];
        }
        return maxArr[i];
    }

    double MinElements(double[] array) //подметод для вычисления минимального элемента массива
    {
        int i = 0;
        double[] maxArr = array;
        maxArr[i] = 0;
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] > maxArr[i]) maxArr[i] = array[j];
        }

        double[] minArr = array;
        minArr[i] = maxArr[i];
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] < minArr[i]) minArr[i] = array[j];
        }

        return minArr[i];
    }

    double maxElements = MaxElements(array);
    double minElements = MinElements(array);
    double result = Math.Round((maxElements - minElements), 1);

    return result;
}


double[] arr = CreateArrayRndInt(10, 10, 100);
PrintArray(arr);
double differenceMaxMinElements = DifferenceMaxMinElements(arr);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {differenceMaxMinElements}");