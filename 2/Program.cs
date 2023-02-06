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

bool ShowElement(int[,] array, int inputString, int inputColumn) // метод вывода искомого элемента в консоль
{
    if ((inputString > -1)
    && (inputString < array.GetLength(0))
    && (inputColumn > -1)
    && (inputColumn < array.GetLength(1)))
    {
        System.Console.WriteLine($"значение заданной ячейки = {array[inputString, inputColumn]}");
        return true;
    }
    System.Console.WriteLine("такого числа в массиве нет");
    return false;
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

int min = InputInt("введите минимальный порог элемента");
int max = InputInt("введите максимальный порог элемента");
int stringmass = InputInt("введите количество строк в создаваемом массиве");
int columnmass = InputInt("введите количество столбцов в создаваемом массиве");
int inputString = InputInt("введите номер строки элемента");
int inputColumn = InputInt("введите номер столбца элемента");

int[,] array = CreatArray(min, max, stringmass, columnmass);

PrintArray(array);
System.Console.WriteLine();
ShowElement(array, inputString, inputColumn);
