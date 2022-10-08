using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IntroductionToProgramming
{
    internal class SeventhLesson
    {
        public static void TaskInit()
        {
            bool isExpectedNumber;
            int taskNumber;
            Console.ForegroundColor = ConsoleColor.Magenta;

            do
            {
                Console.Write("УРОК 7. Введите номер задания (47, 50, 52): ");
                isExpectedNumber = int.TryParse(Console.ReadLine()!, out int result);
                taskNumber = result;
            }
            while (isExpectedNumber != true || !(taskNumber is (int)TaskNumber.FORTYSEVENTH or (int)TaskNumber.FIFTIETH or (int)TaskNumber.FIFTYSECOND));

            switch (taskNumber)
            {
                case (int)TaskNumber.FORTYSEVENTH:
                    FortySeventhTask();
                    break;
                case (int)TaskNumber.FIFTIETH:
                    FiftiethTask();
                    break;
                default:
                    FiftySecondTask();
                    break;
            }
        }

        public static void FortySeventhTask()
        {
            Console.WriteLine("Задача #47 Программно задаётся массив вещественных чисел от -100 до 100 размера m x n, где m,n в диапазоне от 3 до 10: ");
            Random random = new Random();
            double[,] array = new double[random.Next(3, 10), random.Next(3, 10)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = Math.Round(random.NextDouble() * (100 - (-100)) + (-100), 2);
                    Console.Write("{0}\t", array[i, j]);
                }
                Console.WriteLine();
            }
        }

        public static void FiftiethTask()
        {

            Console.WriteLine("Задача #50 Программно задаётся массив чисел от -100 до 100 размера m x n, где m,n в диапазоне от 3 до 10," +
                "введите позицю элемента в массиве: ");
            int[,] array = RectangularIntArray();

            string numbers;
            bool isNumbers;
            Regex numbersString = new(@"^(\d+[,])(\d+)");
            do
            {
                Console.WriteLine("Введите позицию элемента, через запятую (пример 2, 1): ");
                numbers = Console.ReadLine()!;
                isNumbers = numbersString.Match(numbers).Success;
            } while (isNumbers != true);

            var positionNumbers = numbers.Split(',').Select(numberInString => int.Parse(numberInString)).ToArray();

            if (array.GetLength(0) - 1 >= positionNumbers[0] && array.GetLength(1) - 1 >= positionNumbers[1])
            {
                Console.WriteLine($"Элемент на позиции [{positionNumbers[0]},{positionNumbers[1]}]: {array[positionNumbers[0], positionNumbers[1]]}");
            }
            else
            {
                Console.WriteLine($"Элемента по ввеженным индексам нет (не соответствует размеру массива).");
            }
        }

        public static void FiftySecondTask()
        {

            Console.WriteLine("Задача #52 Программно задаётся массив чисел от -100 до 100 размера m x n, где m,n в диапазоне от 3 до 10," +
                "среднее арифметическое элементов в каждом столбце равно: ");
            int[,] array = RectangularIntArray();
            int sumInColumn = 0;
            Console.Write($"values [ ");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    sumInColumn += array[i, j];
                }
                Console.Write($"{sumInColumn} ");
            }
            Console.Write($"]");
        }

        public static int[,] RectangularIntArray()
        {
            Random random = new();
            int[,] array = new int[random.Next(3, 10), random.Next(3, 10)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(-100, 100);
                    Console.Write("{0}\t", array[i, j]);
                }
                Console.WriteLine();
            }
            return array;
        }
    }
}
