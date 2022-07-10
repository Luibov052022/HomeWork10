/* Задача 1: Есть монотонная последовательность, каждое число встречается ровно то количество раз, какое 
значение этого числа: 1, 2, 2, 3, 3, 3, 4, 4, 4, 4,... Выведите ряд этой последовательности до N-го значения, желательно использовать рекурсию:
N = 12 -> "1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5" 8 */



String recursion(int n)
{
    int sum = 0;
    int j = 0;
    if (n == 1 || n <= 0)

    {
        Console.Write("1");
    }
    else
    {
        for (int i = 1; sum < n; i++)
        {
            sum += i;
            j = i;
        }
        Console.Write(recursion(--n) + j);

    }
    return ", ";
}

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}


recursion(Prompt("Введите число: "));

