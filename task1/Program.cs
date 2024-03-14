//Задайте значения M и N. Напишите программу, которая выведет все 
//натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.

Console.WriteLine("Введите N");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите M");
int M = Convert.ToInt32(Console.ReadLine());

void AllNumbersFromNtoM(int N, int M)
{
    if (M <= N - 1) return;
    AllNumbersFromNtoM(N, M-1);
    Console.Write($"{M}, ");
}

AllNumbersFromNtoM(N, M);