using Tyuiu.BerezovskiyAS.Sprint4.Task1.V25.Lib;
{
    Console.Title = "Спринт #4 | Выполнил: Березовский А. С. | ПИНб-25-1";

    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #4                                                               *");
    Console.WriteLine("* Тема: Обработка структурных данных                                      *");
    Console.WriteLine("* Задание #1                                                              *");
    Console.WriteLine("* Вариант #25                                                             *");
    Console.WriteLine("* Выполнил: Березовский Артём Станиславович | ПИНб-25-1                   *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов заполненный         *");
    Console.WriteLine("* значениями с клавиатуры в диапазоне от 0 до 7 подсчитать сумму          *");
    Console.WriteLine("*чётных элементов массива. { 6, 3, 6, 4, 7, 4, 6, 5, 2, 3, 6, 3, 6, 2}    *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");

    DataService ds = new DataService();

    int len;
    Console.Write("Введите количество элементов массива: ");
    len = Convert.ToInt32(Console.ReadLine());

    int[] numsArray = new int[len];

    for (int i = 0; i <= len - 1; i++)
    {
        Console.Write("Введите значение " + i + "элемента массива: ");
        numsArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    Console.WriteLine("Массив: ");
    for (int i = 0; i <= len - 1; i++)
    {
        Console.Write(numsArray[i] + "\t");
    }
    Console.WriteLine();

    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Результат:                                                              *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("Cумма четных чисел: " + ds.Calculate(numsArray));

    Console.ReadLine();
}