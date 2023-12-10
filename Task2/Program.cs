// Знакомство с языками программирования (семинары)
// Урок 4. Функции
// Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

System.Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] FillArray(int size)
{
    int[] numbers = new int[size];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
    }
    return numbers;
}

void PrintArray(int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + " ");
    }
}

bool IsOdd(int num)
{
    return (num % 2 == 0);
}

int GetCount(int[] num)
{
    int count = 0;
    for (int i = 0; i < num.Length; i++)
    {
        if (IsOdd(num[i])) count++;
    }
    return count;
}

int[] list = FillArray(size);

PrintArray(list);

System.Console.WriteLine();

System.Console.WriteLine($"Количество чётных чисел в массиве = {GetCount(list)}.");