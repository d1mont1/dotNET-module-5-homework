using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_module_5_homework
{
    class Program
    {
        static void Main()
        {
            Task1(); // Задача 1
            Task2(); // Задача 2
            Task3(); // Задача 3
            Task4(); // Задача 4
        }

        // Задача 1: Перехватить исключение запроса к несуществующему веб ресурсу
        static void Task1()
        {
            try
            {
                // Попытка выполнить запрос к несуществующему веб-ресурсу
                throw new System.Net.WebException("Сетевая ошибка: ресурс недоступен");
            }
            catch (System.Net.WebException ex)
            {
                // Перехватываем исключение
                Console.WriteLine("Задача 1: Произошла ошибка: " + ex.Message);
            }
            finally
            {
                // Финальный блок (выполнится всегда)
                Console.WriteLine("Завершение задачи 1");
            }
        }

        // Задача 2: Обращение к элементам массива за его пределы
        static void Task2()
        {
            int[] array = { 1, 2, 3 };
            try
            {
                // Попытка обратиться к элементу массива за пределами массива
                int value = array[5];
            }
            catch (IndexOutOfRangeException ex)
            {
                // Перехватываем исключение
                Console.WriteLine("Задача 2: Произошла ошибка: " + ex.Message);
            }
            finally
            {
                // Финальный блок (выполнится всегда)
                Console.WriteLine("Завершение задачи 2");
            }
        }

        // Задача 3: Генерация исключения в одном методе и его "поднятие" в вызывающий метод
        static void Task3()
        {
            try
            {
                temp_func();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Задача 3: Произошла ошибка: " + ex.Message);
            }
        }

        static void temp_func()
        {
            // Генерация исключения
            throw new InvalidOperationException("Исключение внутри метода temp_func");
        }

        // Задача 4: Генерация исключения в одном методе и его "поднятие" в вызывающий метод
        static void Task4()
        {
            try
            {
                temp_func2();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Задача 4: Произошла ошибка: " + ex.Message);
            }
        }

        static void temp_func2()
        {
            // Генерация исключения
            throw new InvalidOperationException("Исключение внутри метода temp_func2");
        }
    }

}
