// ача 64: Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N.

void Numbers(int m, int n)
{
    if (n > m) Numbers(m,n-1);
    Console.WriteLine($"{n}");
    if(m > n) Numbers(m,n + 1);
}
Numbers(10,1);
