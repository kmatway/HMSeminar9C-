// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumNumbers(int m, int n)
{
    if (m == n) return n;
    if (n > m) return n + SumNumbers(m,n-1);
    else return n + SumNumbers(m,n + 1);
}

Console.WriteLine("Введите число A: ");
int A = (int.Parse(Console.ReadLine())); 
Console.WriteLine("Введите число B: ");
int B = (int.Parse(Console.ReadLine()));
Console.WriteLine("Сумма натуральных элементов в промежутке");
Console.WriteLine(SumNumbers(A,B));


