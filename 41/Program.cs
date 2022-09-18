//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] InputArrayElements()
{
    Console.WriteLine("Введи элементы массива через пробел");
    string elements = Console.ReadLine()!;
    string[] elementsSplited = elements.Split(' ');
    int[] array = new int[elementsSplited.Length];

    for (int i = 0; i < elementsSplited.Length; i++)
    {
        array[i] = int.Parse(elementsSplited[i]);
    }
    return array;
}

void PrintArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count += 1;
        }
    }
    Console.Write($"Колличество чисел > 0 в массиве = {count}");
}

PrintArray(InputArrayElements());