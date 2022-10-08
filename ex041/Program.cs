// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

double[] result = InsertArray();
Console.Write("Массив: ");
PrintArray(result);
Console.WriteLine();
Console.WriteLine($"Количество введенных элементов больше нуля составляет: {CheckArray(result)}.");

void PrintArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

double[] InsertArray()
{
    Console.WriteLine("Введи количество элементов массива: ");
    int num = Int32.Parse(Console.ReadLine());
    double[] result = new double[num];
    for(int i = 0; i < num; i++)
    {
        Console.WriteLine($"Введи элемент номер {i+1}: ");
        result[i] = Double.Parse(Console.ReadLine());
    }
    return result;
}

double CheckArray(double[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
