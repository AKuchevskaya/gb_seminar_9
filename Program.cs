// // Задача 64: Выполнить с помощью рекурсии.Задайте значение N. 
// // Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

// // N = 5 -> "5, 4, 3, 2, 1"
// // N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Write("Введите число N: ");
// int N = Int16.Parse(Console.ReadLine()!);
// Console.WriteLine(GetNumbers(N, 1));

// //--------------Рекурсивный метод------------
// string GetNumbers(int start, int end)
// {
//     if (start==end) return end.ToString();
//     return (start + ", " + GetNumbers(start-1, end));
// }


// Задача 66: Выполнить с помощью рекурсии.Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int M = Int16.Parse(Console.ReadLine()!);

Console.Write("Введите число N: ");
int N = Int16.Parse(Console.ReadLine()!);
Console.WriteLine($"M = {M}; N = {N}. -> {GetNumbers(M, N)}");

//--------------Рекурсивный метод------------
int GetNumbers(int a, int b)
{
    if (a == b) return a;
    return (GetNumbers(a + 1, b) + a);
}

// Задача 68: Выполнить с помощью рекурсии.Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
