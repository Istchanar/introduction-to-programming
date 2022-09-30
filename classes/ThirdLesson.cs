using IntroductionToProgramming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IntroductionToProgramming
{
    internal class ThirdLesson
    {
        private int taskNumber;
        public void TaskInit()
        {
            bool isExpectedNumber;
            int taskNumber;
            Console.ForegroundColor = ConsoleColor.Magenta;

            do
            {
                Console.Write("УРОК 3. Введите номер задания: ");
                isExpectedNumber = int.TryParse(Console.ReadLine()!, out int result);
                taskNumber = result;
            }
            while (isExpectedNumber != true || !(taskNumber is (int)TaskNumber.NINETEENTH or (int)TaskNumber.TWENTYFIRST or (int)TaskNumber.TWENTYTHIRD));

            this.taskNumber = taskNumber;

            switch (taskNumber)
            {
                case (int)TaskNumber.NINETEENTH:
                    NineteenthTask();
                    break;
                case (int)TaskNumber.TWENTYFIRST:
                    TwentyfirstTask();
                    break;
                default:
                    TwentythirdTask();
                    break;
            }
        }
        public void NineteenthTask()
        {
            Console.WriteLine("Задача #19 Введите пятизначное число для проверки, является ли оно палиндромом: ");
            string numberFromString;
            int numberFromConsole;
            bool numberCheck;

            do
            {
                Console.WriteLine("Введите пятизначное число:");
                numberFromString = Console.ReadLine()!;
                numberCheck = int.TryParse(numberFromString, out int number);
                // Если каст из строки отрицательное число, то переводим его в положительное
                // перезаписываем строку с числом.
                numberFromString = number < 0 ? Math.Abs(number).ToString() : numberFromString;
                numberFromConsole = number;

            } while (numberCheck != true || numberFromConsole > 100000 || numberFromConsole < -100000);


            int[] numberArray = new int[numberFromString.Length];
            for (int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] = int.Parse(numberFromString[i].ToString());
            }


            bool palendromCheck = true;
            for (int i = 0; i < numberArray.Length / 2; i++)
            {
                if (numberArray[i] != numberArray[numberArray.Length - 1 - i])
                {
                    palendromCheck = false;
                    break;
                }
            }

            Console.WriteLine(palendromCheck ? "Палиндром" : "Не палиндром");
        }
        public void TwentyfirstTask()
        {
            Console.WriteLine("Задача #21 Введите координаты двух точек для определения расстояния между ними в 3D простронстве: ");

            string pointA;
            string pointB;
            bool isPatternPointA;
            bool isPatternPointB;
            Regex numbersString = new Regex(@"^(?:\-?\d+[, ]*)+$");
            do
            {
                Console.WriteLine("Координаты точки А, через запятую: ");
                pointA = Console.ReadLine()!;
                isPatternPointA = numbersString.Match(pointA).Success;
            } while (isPatternPointA != true);

            do
            {
                Console.WriteLine("Координаты точки B, через запятую: ");
                pointB = Console.ReadLine()!;
                isPatternPointB = numbersString.Match(pointB).Success;
            } while (isPatternPointB != true);

            var coordinatesOfPointA = pointA.Split(',').Select(numberInString => int.Parse(numberInString)).ToArray();
            var coordinatesOfPointB = pointB.Split(',').Select(numberInString => int.Parse(numberInString)).ToArray();

            double squaresOfDifferenceTwoNumbers = 0;

            for (int i = 0; i < coordinatesOfPointA.Length; i++)
            {
                squaresOfDifferenceTwoNumbers += Math.Pow((coordinatesOfPointA[i] - coordinatesOfPointB[i]), 2);
            }
            var distance = Math.Sqrt(squaresOfDifferenceTwoNumbers);

            Console.WriteLine(distance);
        }
        public void TwentythirdTask()
        {
            Console.WriteLine("Задача #23 Введите число N для получения кубов числе от 1 до N: ");

            string numberFromString = Console.ReadLine()!;
            bool numberCheck = int.TryParse(numberFromString, out int number);

            int numberValue = number;

            Console.Write($"Кубы от 1 до N: ");
            for (int i = 1; i <= numberValue; i++)
            {
                Console.Write($"{Math.Pow(i, 3)} ");
            }
        }
    }
}
