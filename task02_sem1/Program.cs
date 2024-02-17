

Console.WriteLine("Введите целое натуральное число");
int num = Convert.ToInt32(Console.ReadLine());

if (num <= 0)
{

    Console.WriteLine("Некорректный ввод!");
    return;
}


int count = -num;

while (count <= num)
{

    Console.WriteLine(count + "");
    count = count + 1;

}
