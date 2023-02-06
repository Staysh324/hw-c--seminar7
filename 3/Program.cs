int InputInt(string message) // метод ввода числа
{
    Console.Write(message + ":");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

int[,] CreatArray(int min, int max, int stringmass, int columnmass) // метод создания массива с случайными числами
{                                                                   // случайные числа и размер массива вводятся с клавиатуры
    int[,] array = new int[stringmass, columnmass];
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

void PrintArray(int[,] array) // вывод массива в консоль
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}; ");
        }
    }
}

void Average(int[,] array) // метод поиска среднего арифметического в столбцах массива
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double average = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            average += array[i, j];
        }
        System.Console.Write($"{average / (array.GetLength(0)+1):f1}; ");
    }
}

int min = InputInt("введите минимальный порог элементов массива");
int max = InputInt("введите максимальный порог элементов массива");
int stringmass = InputInt("введите количество строк в создаваемом массиве");
int columnmass = InputInt("введите количество столбцов в создаваемом массиве");

int[,] array = CreatArray(min, max, stringmass, columnmass);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine("средние арифметические стобцов:");
Average(array);