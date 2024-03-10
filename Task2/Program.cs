// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int FindAckermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return FindAckermann(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return FindAckermann(m - 1, FindAckermann(m, n - 1));
    }
    return 0;
}
Console.Write(FindAckermann(2, -3));

