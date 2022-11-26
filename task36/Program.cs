// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Задать размер массива");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

int[] Method4()
{
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(-99, 100);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    return array;
}

// Считем суммы элемнтов, стоящих на нечетных позициях
void Method2(int[] array)
{
    int sum = 0;
    for (int i = 1; i < n; i += 2)
    {
        sum = sum + array[i];
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях в массиве равна " + sum);
}

int[] res = Method4();

Method2(res);