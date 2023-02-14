/* Автор: Богулянов Семен *
* Группа: ПИ-221 *
* Дата: 13.02.23 *
* Название: Базовые понятия языка C# */

using System;
using System.Collections.Specialized;

namespace Lab2
{
    class Programm
    {
        static void Task1()
        {

            double A, Result;
            int N, Counter;

            Result = 0;

            Console.Write("Введите число A: ");
            A = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите степень N: ");
            N = Convert.ToInt32(Console.ReadLine());

            for (Counter = 0; Counter < N; ++Counter)
            {
                Result = A * A;

            }

            Console.Write($"Результат равен: {Result}\n");


        }

        static void Task2()
        {
            Console.WriteLine("Введите трёхзначное число или больше");

            string Number = Console.ReadLine();
            string NewNumber = "";
            int NumberIndex;

            for (NumberIndex = 0; NumberIndex < Number.Length; ++NumberIndex)
            {

                if (NumberIndex == 1)
                {
                    NumberIndex = NumberIndex + 1;
                }

                NewNumber = NewNumber + Number[NumberIndex];
            }

            NewNumber = NewNumber + Number[1];

            Console.WriteLine($"Новое число: {NewNumber}");
        }

        static void Main(string[] args)
        {
            bool Exit = true;

            while (Exit)
            {

                Console.WriteLine("Номер 1 \nНомер 2");
                Console.WriteLine("Что бы выбрать первый номер нажмите 1, что бы выбрать второй номер нажмите 2, что бы выйти нажмите 3");

                string Choise = Console.ReadLine();

                switch (Choise)
                {
                    case "1":
                        Task1();
                        break;
                    case "2":
                        Task2();
                        break;
                    case "3":
                        Exit = false;
                        break;
                    default:
                        Console.WriteLine("Такого варианта ответа нет, нажмите 1, 2 или 3");
                        break;
                }
            }
        }
    }
}