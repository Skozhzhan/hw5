// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("Задать размер массива");
int n = Convert.ToInt32(Console.ReadLine());

double[] array = new double[n];
double[] Method4()
{
    for (int i = 0; i < n; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(-9, 10)) / 10;
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    return array;
}
double[] res = Method4();

// Поиск максимального
double Method4_Max()
{
    double max = array[0];

    for (int i = 0; i < n; i++)
    {
        if (array[i] > max)
            max = array[i];
    }
    return max;

}

double Max = Method4_Max();
Console.WriteLine("Max " + Max);

// Поиск минимального
double Method4_Min()
{

    double min = array[0];

    for (int i = 1; i < n; i++)
    {
        if (array[i] < min)
            min = array[i];
    }
    return min;

}

double Min = Method4_Min();
Console.WriteLine("Min " + Min);

// Разность максимального и минимального
double D = Max - Min;
Console.WriteLine("Max - Min = " + D);
