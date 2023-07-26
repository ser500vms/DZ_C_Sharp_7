// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

List<double> FindAverage(int[,] arrey)
{
    List<double> dynamicArrey = new List<double>();
    for (int j = 0; j < arrey.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arrey.GetLength(0); i++)
        {
            sum += arrey[i, j];
        }
        double averege = sum / arrey.GetLength(0);
        dynamicArrey.Add(Math.Round(averege, 2));
        }
    return dynamicArrey;
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


int rows = GetInput("Введите колличество строк: ");
int collums = GetInput("Введите колличество столбцов: ");
int startValue = GetInput("Введите диапазон (от): ");
int finishValue = GetInput("Введите диапазон (до): ");
int[,] twoDemensionArrey = Generate2DArray(rows, collums, startValue, finishValue);
Print2DArray(twoDemensionArrey);
Console.WriteLine("");

List<double> arrey = FindAverage(twoDemensionArrey);
Console.Write($"Среднее арифметическое каждого столбца: {String.Join("; ", arrey)}.");
