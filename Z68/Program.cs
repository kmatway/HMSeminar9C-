// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

Console.WriteLine("Введите неотрицательное число A: ");
int A = (int.Parse(Console.ReadLine())); 
Console.WriteLine("Введите неотрицательное число B: ");
int B = (int.Parse(Console.ReadLine()));
Console.WriteLine(Ackerman(A,B));

int Ackerman(int m, int n)
{
    if(m == 0) return n+1;
    else if(m > 0 & n == 0) return Ackerman(m-1,1);
    return Ackerman(m-1,Ackerman(m,n-1));
}

