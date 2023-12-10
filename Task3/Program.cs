// Знакомство с языками программирования (семинары)
// Урок 4. Функции
// Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)
// [1 3 5 6 7 8] => [8 7 6 5 3 1]

System.Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] FillArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int[] ReverseArray(int[] arr)
{
    size = arr.Length;
    int tempElement = 0;
    for (int i = 0; i < size / 2; i++)
    {
        tempElement = arr[size - 1 - i];
        arr[size - 1 - i] = arr[i];
        arr[i] = tempElement;
    }
    return arr;
}

int[] list = FillArray(size);
PrintArray(list);
System.Console.WriteLine();
PrintArray(ReverseArray(list));
