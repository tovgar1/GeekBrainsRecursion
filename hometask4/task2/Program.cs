//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

using System.Globalization;

Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine());

int Accerman(int num, int argument)
{
    int result = argument;
    if (num == 0) return argument++;
    if (num == 0)
    {
        result = num++;
    }
    if (num > 0 && argument == 0)
    {
        result = Accerman(num-1, 1);
    }
    if (num > 0 && argument > 0)
    {
        result = Accerman(num-1, Accerman(num, argument-1));
    }
    return result;
}
Console.WriteLine(Accerman(n, m));

//Честно? Не понял функцию Аккермана