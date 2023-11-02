// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int ReadInt(string msg)
{
    Console.WriteLine(msg);
    string a = Console.ReadLine();
    int number;
    number = int.Parse(a);
    return number;
}

int[] CreateArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = ReadInt($"Enter number {i + 1}: ");
    }
    return array;
}

int CountPositiveNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0)
        {
            count++;
        }
    }
    return count;
}

void printArray(int[] array)
{
    Console.Write(array[0]);
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($", {array[i]}");
    }
    Console.WriteLine();
}

int length = ReadInt("Enter length array:");
int[] array = CreateArray(length);
printArray(array);
Console.WriteLine($"Count positive number {CountPositiveNumber(array)}");