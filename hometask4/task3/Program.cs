//Задайте произвольный массив. Выведете его элементы, начиная с конца. 
//Использовать рекурсию, не использовать циклы.

Random rnd = new Random();

int[] array = new int[rnd.Next(5, 15)];//массив с случайной длинной

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(-5, 10);//случайный элемент
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

PrintArray(array);

void PrintArrayReversed(int[] arr, int index) //использовал нейросеть; сам так и не додумался
{
    if (index >= 0)
    {
        Console.Write($"{arr[index]} ");
        PrintArrayReversed(arr, index - 1);
    }
}

Console.WriteLine();
PrintArrayReversed(array, array.Length - 1);