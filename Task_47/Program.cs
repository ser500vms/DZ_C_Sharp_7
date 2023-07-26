// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] Generate2DArray(int rows, int collums, double startValue, double finishValue)
{
    double[,] array = new double[rows, collums];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble() * (finishValue - startValue) + startValue;
            array[i, j] = Math.Round(array[i, j], 1);
        }
    }
    return array;
}

void Print2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(String.Format("{0, 4}", array[i, j]));
            Console.Write("\t", -5);
        }
        Console.WriteLine();
    }
}

double[,] twoDemensionArray = Generate2DArray(3, 4, -10, 10);
Print2DArray(twoDemensionArray);

