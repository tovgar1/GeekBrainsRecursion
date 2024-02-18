// See https://aka.ms/new-console-template for more information
// Напишите программу, которая принимает на вход 
//трёхзначное целое число и на выходе показывает сумму 
//первой и последней цифры этого числа.
// 456  =>  10
// 782  =>  9
// 918  =>  17

Console.WriteLine("Введите трехзначное целое число");

int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 && number >= 1000)
{
    return;
}
else
{

    int firstNumber = number / 100;
    int secondNumber = (number - (firstNumber * 100)) / 10;
    int thirdNumber = (number - (firstNumber * 100 + secondNumber * 10));

    Console.WriteLine(firstNumber + thirdNumber);

}

