
Console.WriteLine("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
bool result = num1 == num2 * num2;
string resultStr = result ? "да" : "нет";
Console.WriteLine($"a = {num1}, b = {num2}, {resultStr}");


