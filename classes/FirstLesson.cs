using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace IntroductionToProgramming
{
    internal class FirstLesson
    {
        private float firstNumber, secondNumber, thirdNumber, answer;
        private int taskNumber;

        public void TaskInit()
        {
            bool isExpectedNumber;
            int taskNumber;
            Console.ForegroundColor = ConsoleColor.Magenta;

            do
            {
                Console.Write("УРОК 1. Введите номер задания: ");
                isExpectedNumber = int.TryParse(Console.ReadLine()!, out int result);
                taskNumber = result;
            }
            while (isExpectedNumber != true || !(taskNumber is (int)TaskNumber.SECOND or (int)TaskNumber.FOURTH or (int)TaskNumber.SIXTH or (int)TaskNumber.EIGHTH));

            this.taskNumber = taskNumber;

            switch (taskNumber)
            {
                case (int)TaskNumber.SECOND:
                    SecondTask();
                    break;
                case (int)TaskNumber.FOURTH:
                    FourthTask();
                    break;
                case (int)TaskNumber.SIXTH:
                    SixthTask();
                    break;
                default:
                    EighthTask();
                    break;
            }
        }
        public void TaskDataSet()
        {

            try
            {
                firstNumber = float.Parse(Console.ReadLine()!);

                if (taskNumber == (int)TaskNumber.SECOND || taskNumber == (int)TaskNumber.FOURTH)
                {
                    secondNumber = float.Parse(Console.ReadLine()!);
                }

                if (taskNumber == (int)TaskNumber.FOURTH)
                {
                    thirdNumber = float.Parse(Console.ReadLine()!);
                }

            }
            catch (FormatException error)
            {
                Console.WriteLine($"Введены неправильные данные: \n {error}");
            }
        }
        public void SecondTask()
        {
            Console.WriteLine($"Задача #2 Введите два числа, чтобы узнать большее: ");
            TaskDataSet();

            if (firstNumber > secondNumber)
            {
                Console.WriteLine($"Большее число: {firstNumber}, меньшее число {secondNumber}");
            }
            else
            {
                Console.WriteLine($"Большее число: {secondNumber}, меньшее число {firstNumber}");
            }
        }
        public void FourthTask()
        {
            Console.WriteLine($"Задача #4 Введите три числа, чтобы узнать большее: ");
            TaskDataSet();
            answer = firstNumber > secondNumber && firstNumber > thirdNumber
                   ? firstNumber : secondNumber > thirdNumber ? secondNumber : thirdNumber;
            Console.WriteLine($"Большее число: {answer}");
        }
        public void SixthTask()
        {
            Console.WriteLine($"Задача #6 Для проверки чётности введите число: ");
            TaskDataSet();
            Console.WriteLine(firstNumber % 2 == 0 ? $"Число {firstNumber} чётное." : $"Число {firstNumber} нечётное.");
        }
        public void EighthTask()
        {

            Console.WriteLine($"Задача #8 Для показа ряда введёного числа от 1 до N c шагом 2 введите число: ");
            TaskDataSet();
            answer = firstNumber % 2 == 0 ? firstNumber : firstNumber - 1;
            Console.WriteLine($"Ряд чисел с шагом в 2: ");
            do
            {
                Console.Write($"{answer} ");
                answer -= 2;
            }
            while (answer > 1);
        }
    }
}
