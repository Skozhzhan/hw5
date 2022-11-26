// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.WriteLine("Задать размер массива");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
//  Считаем четные
int count = 0;
for (int i = 0; i < n; i++)
{
    if (array[i] % 2 == 0)
        count = count + 1;
}
Console.WriteLine($"Количество четных чисел в массиве равно {count} ");
