// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void PrintArray(int[] array)
{
    Console.WriteLine("Вывод массива: ");
    int n = 0;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
        if (array[i] > 0)
        {
            n = n + 1;
        }

    }

    Console.Write($"Количество элементов больше нуля: {n}");
}
int[] Massive(int size)
{
    int[] ar = new int[size];
    for (int i = 0; i < size; i++)
    {

        Console.WriteLine($"Введите элемент массива  под индексом {i}: ");
        ar[i] = int.Parse(Console.ReadLine());
    }
    return ar;
}
int EnterSize(string text)
{
    Console.Write(text);
    int n = int.Parse(Console.ReadLine());
    return n;
}
int size = EnterSize("Введите размер массива: ");
int[] array = Massive(size);
PrintArray(array);

