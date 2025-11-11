using Tyuiu.BerezovskiyAS.Sprint4.Task6.V25.Lib;
{
    DataService ds = new DataService();


    Console.Title = "Спринт #4 | Выполнил: Березовский А. С. │ ПИНб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #4                                                               *");
    Console.WriteLine("* Тема: Класс Array                                                       *");
    Console.WriteLine("* Задание #6                                                              *");
    Console.WriteLine("* Вариант #25                                                             *");
    Console.WriteLine("* Выполнил: Березовский Артём Станиславович  | ПИНб-25-1                  *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Дан строковый массив данных, используя класс Array подсчитайте          *");
    Console.WriteLine("* количество элементов, длина которых больше 6.                           *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");

    string[] array = new string[] { "Теннис", "Футбол", "Крикет", "Баскетбол", "Бейсбол", "Регби", "Хоккей" };
    Console.WriteLine("Исходный массив:");

    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }

    Console.WriteLine();
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("Количество элементов, длина которых больше 6:");
    int res = ds.Calculate(array);

    Console.WriteLine(res);

    Console.ReadKey();
}