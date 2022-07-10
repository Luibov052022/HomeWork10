// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

static int Akkerman(int n, int m)
{
    if (n == 0)
        return m + 1;
    else if (n != 0 && m == 0)
        return Akkerman(n - 1, 1);
   
     return Akkerman(n - 1, Akkerman(n, m - 1));
}

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

   Console.WriteLine(Akkerman(Prompt("Введите число 1: "), Prompt("Введите число 2: ")));

