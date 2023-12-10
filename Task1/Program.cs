// Знакомство с языками программирования (семинары)
// Урок 4. Функции
// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

string symbols = "", msg = "Сумма цифр введённого числа оказалась чётной!";

int GetSumOfDigits(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

bool EndInput(string str)
{
    if (str == "q" ||
    str == "Q" ||
    str == "й" ||
    str == "Й") return true;
    return false;
}

do
{
    Console.Clear();    
    System.Console.Write("Введите число.\nПрограмма завершает работу, если будет нажата клавиша 'q'\nили сумма цифр числа чётная: ");
    Console.WriteLine();
    symbols = Console.ReadLine();
    if (EndInput(symbols))
    {
        msg = "Вы ввели стоп-символ!";
        break;
    }

} while (GetSumOfDigits(Convert.ToInt32(symbols)) % 2 != 0);

System.Console.WriteLine($"Программа завершена! {msg}");
