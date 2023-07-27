// Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Вариантн №1: Ищем есть ли в сгенерированном массиве заданное число.

string FindNumberIndex(int[,] arrey, int number)
{
    bool numberExist = false;
    string text = "В массиве отсутствует";
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            if (arrey[i, j] == number)
            {
                numberExist = true;
                text = $"находится в массиве на позиции [{i}, {j}]";
                i = arrey.GetLength(0);
                break;
            }
        }
    }
    return text;
}

int[,] Generate2DArray(int rows, int collums, int startValue, int finishValue)
{
    int[,] arrey = new int[rows, collums];
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            arrey[i, j] = new Random().Next(startValue, finishValue + 1);
        }
    }
    return arrey;
}

void Print2DArray(int[,] arrey)
{
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            Console.Write(String.Format("{0, 3}", arrey[i, j]));
            Console.Write("\t", -5);
        }
        Console.WriteLine();
    }
}

int GetInput(string text)
{
    Console.Write(text);
    string num = Console.ReadLine();
    int value = 0;
    int count = 0;

    while (count == 0)
    {
        if (int.TryParse(num, out value))
        {
            count = 1;
        }
        else
        {
            Console.Write("Вы ввели неверное значение, введите новое значение: ");
            num = Console.ReadLine();
            count = 0;
        }
    }
    return value;
}


int rows = GetInput ("Введите колличество строк: ");
int collums = GetInput ("Введите колличество столбцов: ");
int startValue = GetInput ("Введите диапазон (от): ");
int finishValue = GetInput ("Введите диапазон (до): ");
int[,] twoDemensionArrey = Generate2DArray(rows, collums, startValue, finishValue);
int number = GetInput ("Введите искомое число: ");
Print2DArray(twoDemensionArrey);
Console.WriteLine();
string numberIndex = FindNumberIndex(twoDemensionArrey, number);
Console.Write($"Искомое число {number} -> {numberIndex}");


// Вариантн №2: Ищем число в массиве по заданному индексу.

// string FindNumber(int[,] arrey, int row, int collums)
// {
//     string text = String.Empty;
//     int number;
//     if (row >= arrey.GetLength(0) || collums >= arrey.GetLength(1))
//     {
//         text = "По индексу [{row}, {collums}] значения отсутсвуют. Вы вышли за пределы массива"; 
//     }
//     else
//     {
//         number = arrey[row, collums];
//         text = $"По индексу [{row}, {collums}] находится число {number}";
//     } 
//     return text;

// }

// int[,] Generate2DArray(int rows, int collums, int startValue, int finishValue)
// {
//     int[,] arrey = new int[rows, collums];
//     for (int i = 0; i < arrey.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrey.GetLength(1); j++)
//         {
//             arrey[i, j] = new Random().Next(startValue, finishValue + 1);
//         }
//     }
//     return arrey;
// }

// void Print2DArray(int[,] arrey)
// {
//     for (int i = 0; i < arrey.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrey.GetLength(1); j++)
//         {
//             Console.Write(String.Format("{0, 3}", arrey[i, j]));
//             Console.Write("\t", -5);
//         }
//         Console.WriteLine();
//     }
// }

// int GetInput(string text)
// {
//     Console.Write(text);
//     string num = Console.ReadLine();
//     int value = 0;
//     int count = 0;

//     while (count == 0)
//     {
//         if (int.TryParse(num, out value))
//         {
//             count = 1;
//         }
//         else
//         {
//             Console.Write("Вы ввели неверное значение, введите новое значение: ");
//             num = Console.ReadLine();
//             count = 0;
//         }
//     }
//     return value;
// }


// int rows = GetInput ("Введите колличество строк: ");
// int collums = GetInput ("Введите колличество столбцов: ");
// int startValue = GetInput ("Введите диапазон (от): ");
// int finishValue = GetInput ("Введите диапазон (до): ");
// int[,] twoDemensionArrey = Generate2DArray(rows, collums, startValue, finishValue);
// int desiredRow = GetInput ("Введите искомую строку: ");
// int desiredString = GetInput ("Введите искомый ряд: ");
// string findNumber = FindNumber(twoDemensionArrey, desiredRow, desiredString);
// Print2DArray(twoDemensionArrey);
// Console.WriteLine("");
// Console.Write(findNumber);

