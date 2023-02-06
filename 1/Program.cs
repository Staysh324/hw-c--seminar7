int InputInt(string message) // метод ввода числа
{
    Console.Write(message + ":");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

double[,] CreateArray(int min, int max) // метод создания массива с вещественными случайными числами
{                                       // случайные числа вводятся с клавиатуры
    double[,] array = new double[3, 4];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max);
        }
    }
    return array;
}

void PrintArray(double[,] array) // метод вывода массива в консоль
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]:f1}; ");
        }
    }
    System.Console.WriteLine();
}

int min = InputInt("введите минимальный порог");
int max = InputInt("введите максимальный порог");
double[,] arr = CreateArray(min, max);
System.Console.Write("получившийся двумерный массив:");
PrintArray(arr);