// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

void LineOfDigits(int M, int N)
{
    if (N < M)
    {
        return;
    }
    Console.Write($"{M} ");
    LineOfDigits(M + 1, N);
    
}
LineOfDigits(2, 15);

// А можно вместо последней строки сделать ввод чисел промежутка с консоли:
// Console.WriteLine("Введите первое число промежутка: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите первое число промежутка: ");
// int N = Convert.ToInt32(Console.ReadLine());
// LineOfDigits(M, N);