using Tyuiu.BerezovskiyAS.Sprint4.Task4.V9.Lib;
{
    DataService ds = new DataService();

    Console.Title = "Спринт #4 | Выполнил: Березовский А. С. | ПИНб-25-1";

    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #4                                                               *");
    Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
    Console.WriteLine("* Задание #4                                                              *");
    Console.WriteLine("* Вариант #9                                                              *");
    Console.WriteLine("* Выполнил: Березовский Артём Станиславович | ПИНб-25-1                   *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");

    Console.WriteLine("Строки: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Таблицы: ");
    int cols = Convert.ToInt32(Console.ReadLine());

    int[,] matrix = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.WriteLine($"Введите {i}, {j} элемента матрицы: ");
            matrix[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }

    Console.WriteLine("***************************************************************************");

    Console.WriteLine("\nМассив: ");
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.WriteLine($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");

    int res = ds.Calculate(matrix);
    Console.WriteLine(res);
    Console.ReadKey();
}