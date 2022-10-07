using System;
using System.Diagnostics;


namespace Para1
{
    internal static class Program
    {
        private static void Main()
        {
            var mas = new int[50000]; // массив
 
            var random = new Random();//создание числа
            for (var i = 0; i < mas.Length; i++)
                mas[i] = random.Next(int.MaxValue);// задаем число в массиве
 
            Console.WriteLine("Вычисление...");
            var stopWatch = Stopwatch.StartNew();// создание объекта вычисления времени
            Sort(mas);
            stopWatch.Stop();
 
            Check(mas);
            Console.WriteLine($"Время: {stopWatch.ElapsedMilliseconds} мс");// вывод времени
        }
 
        private static void Sort(int[] array)//класс для поиска
        {
            bool flag;
            do
            {
                flag = false;
                for (var i = 0; i < array.Length - 1; i++)
                    if (array[i] > array[i + 1])
                    {
                        var temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        flag = true;
                    }
            }
            while (flag);
        }
 
        private static void Check(int[] array) //правильность массива
        {
            var check = true;
            for (var i = 0; i < array.Length - 1; i++)
                if (array[i] > array[i + 1])
                {
                    check = false;
                    break;
                }
            Console.WriteLine($"Правильность массива: {check}");
        }
    }
}