using Tyuiu.BerezovskiyAS.Sprint4.Task7.V6.Lib;
{
    DataService ds = new DataService();

    Console.Title = "Спринт #4 | Выполнил: Березовский А. С. | ПИНб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #4                                                               *");
    Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
    Console.WriteLine("* Задание #7                                                              *");
    Console.WriteLine("* Вариант #6                                                              *");
    Console.WriteLine("* Выполнил: Березовский Артём Станиславович | ПИНб-25-1                   *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Написать программу, которая получает от пользователя 12 одноразрядных   *");
    Console.WriteLine("* чисел, записанных друг за другом без разделителей, затем образует из    *");
    Console.WriteLine("* них матрицу 3 на 4, потом вычисляет сумму её нечётных элементов и       *");
    Console.WriteLine("* выводит её на экран                                                     *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");

    Console.WriteLine("Введите числа друг за другом:");

    string s = Console.ReadLine();
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Образованная матрица:                                                   *");

    int[,] arr = new int[4, 3];

    int pos = 0;
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            arr[i, j] = s[pos++] - '0';
            Console.Write(arr[i, j] + " ");
        }
        Console.Write('\n');
    }

    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");


    int ans = ds.Calculate(3, 4, s);

    Console.WriteLine(ans);

    Console.ReadLine();
}