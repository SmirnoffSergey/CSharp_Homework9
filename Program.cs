// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все
// натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.Write("Введите число M = ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N = ");
int N = Convert.ToInt32(Console.ReadLine());
if (M > N) return;
string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + ", " + PrintNumbers(start + 1, end));
}

Console.WriteLine($"Числа от {M} до {N}: "{PrintNumbers(M, N)}" ");










// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M = ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N = ");
int N = Convert.ToInt32(Console.ReadLine());

int SumMN(int start, int end)
{
    if (start == end) return end;
    else return end + SumMN(start, end - 1);
}

Console.WriteLine($"Сумма чисел от {M} до {N} равна {SumMN(M, N)}");










// Ex68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

Console.Write("Введите число M = ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N = ");
int N = Convert.ToInt32(Console.ReadLine());

int FunctionAnkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return FunctionAnkerman(m - 1, 1);
        else if (m > 0 && n > 0) return FunctionAnkerman(m - 1, FunctionAnkerman(m, n - 1));
            else return -1;
}

Console.WriteLine($"A({M},{N}) = {FunctionAnkerman(M, N)}");