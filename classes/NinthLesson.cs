using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToProgramming
{
    internal class NinthLesson
    {
        public static void TaskInit()
        {
            bool isExpectedNumber;
            int taskNumber;
            Console.ForegroundColor = ConsoleColor.Magenta;

            do
            {
                Console.Write("УРОК 9. Введите номер задания (64, 66, 68): ");
                isExpectedNumber = int.TryParse(Console.ReadLine()!, out int result);
                taskNumber = result;
            }
            while (isExpectedNumber != true ||
            !(taskNumber is
            (int)TaskNumber.SIXTYFOURTH or
            (int)TaskNumber.SIXTYSIXTH or
            (int)TaskNumber.SIXTYEIGHTH));

            switch (taskNumber)
            {
                case (int)TaskNumber.SIXTYFOURTH:
                    SixtyFourthTask();
                    break;
                case (int)TaskNumber.SIXTYSIXTH:
                    SixtySixthTask();
                    break;
                default:
                    SixtyEighthTask();
                    break;
            }
        }
        public static void SixtyFourthTask()
        {
            Console.WriteLine("Задание #64 Программно задаётся число N, где N in [2 - 40]; рекурсивно выводятся числа от N до 1.");
            Random random = new();
            int value = random.Next(2, 40);
            Console.WriteLine($"Сгенерировано число N: {value}");
            RecursiveNumbersOutput(value);
        }
        public static void SixtySixthTask()
        {
            Console.WriteLine("Задание #66 Программно задаются числа M и N, где M < N и M in [1 - 24], N in [25 - 50];" +
                "рекурсивно находится сумма натуральных чисел в промежутке [M - N].");
            Random random = new();
            int valueM = random.Next(1, 24);
            int valueN = random.Next(24, 50);
            Console.WriteLine($"M = {valueM}, N = {valueN}");
            Console.WriteLine($"{SumFromMtoN(valueM, valueN)}");
        }
        public static void SixtyEighthTask()
        {
            Console.WriteLine("Задание #68 Программно вычисляется значение функции Аккермана с помощью рекурсии;" +
               "значения m, n передаваемые в функцию A(M, N) ограничены M in [0 - 3], N in [0 - 9]");
            Random random = new();
            int valueM = random.Next(0, 3);
            int valueN = random.Next(0, 9);
            Console.WriteLine($"M = {valueM}, N = {valueN}");
            // Переполнение стека наступает при следующих значениях:
            // m = 3 n = 10
            // m = 2 n = 6882
            // m = 1 n = 13764
            Console.WriteLine($"{AckermannFunction(valueM, valueN)}");
        }

        static void RecursiveNumbersOutput(int value)
        {
            if (value == 0) return;
            Console.Write($"{value} ");
            RecursiveNumbersOutput(value - 1);
        }

        static int SumFromMtoN(int m, int n)
        {
            int sum = 0;
            // Условие, чтобы не получить переполнение стека;
            if (n > 16000 || m > 16000) return 0;
            sum = m <= n ? m + SumFromMtoN(m + 1, n) : sum;
            return sum;
        }

        static int AckermannFunction(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            else if (m > 0 && n == 0)
            {
                return AckermannFunction(m - 1, 1);
            }
            else if (m > 0 && n > 0)
            {
                return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
            }
            else {
                return 0;
            }
        }
    }
}
