void FillArray(int[] array, int MinValue = -9, int MaxValue = 9) //заполнение массива ранодмными числами 
{
    MinValue++;
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(MinValue, MaxValue);
    }
}

void PrintArray(int[] array) // вывод массива на экран
{
    Console.WriteLine($"Вывод массива");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write($" ");
}

int krat(int[] array)// кратность 
{
    int krat = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            krat = krat + 1;
    }
    return krat;
}

int SumNegIndex(int[] array)// сумма нечетных индексов
{
    int sum = 0;
    int i = 0;
    while (i < array.Length)
    {
        sum = sum + array[i];
        i = i + 2;
    }
    return sum;
}

int Difference(int[] array)// разница между МИН и Макс
{
    int min = array[0];
    int max = array[0];
    int i = 1;
    while (i < array.Length)
    {
        if (max < array[i])
            max = array[i];
        if (min > array[i])
            min = array[i];
        i = i + 1;
    }
    return max - min;
}


void Task34()
{
    //Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
    //Напишите программу, которая покажет количество чётных чисел в массиве.
    //[345, 897, 568, 234] -> 2

    int size = 12;
    int[] array = new int[size];
    FillArray(array, 100, 999);
    PrintArray(array);
    Console.WriteLine(" ");
    Console.Write($"Количество чётных чисел в массиве: {krat(array)}");

}

void Task36()
{
    //Задача 36: Задайте одномерный массив, заполненный случайными числами.
    //Найдите сумму элементов с нечётными индексами.

    int size = 5;
    int[] array = new int[size];
    FillArray(array, 1, 9);
    PrintArray(array);
    Console.WriteLine(" ");
    Console.Write($"Сумма элементов с нечётными индексами: {SumNegIndex(array)}");
    ;
}

void Task38()
{
    //Задайте массив вещественных чисел. 
    //Найдите разницу между максимальным и минимальным элементами массива.
    int size = 5;
    int[] array = new int[size];
    FillArray(array, 1, 10);
    PrintArray(array);
    Console.WriteLine(" ");
    Difference(array);
    Console.Write($"Разница между максимальным и минимальным элементов массива: {Difference(array)}");

}

Console.Clear();
Task38();



