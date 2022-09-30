using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToProgramming
{
    internal class SecondLesson
    {
        private int taskNumber;

        public void TaskInit()
        {
            bool isExpectedNumber;
            int taskNumber;
            Console.ForegroundColor = ConsoleColor.Magenta;

            do
            {
                Console.Write("УРОК 2. Введите номер задания: ");
                isExpectedNumber = int.TryParse(Console.ReadLine()!, out int result);
                taskNumber = result;
            }
            while (isExpectedNumber != true || !(taskNumber is (int)TaskNumber.TENTH or (int)TaskNumber.THIRTEENTH or (int)TaskNumber.FIFTEENTH));

            this.taskNumber = taskNumber;

            switch (taskNumber)
            {
                case (int)TaskNumber.TENTH:
                    TenthTask();
                    break;
                case (int)TaskNumber.THIRTEENTH:
                    ThirteenthTask();
                    break;
                default:
                    FifteenthTask();
                    break;
            }
        }
        public void TenthTask()
        {
            Console.WriteLine("Задача #10 Введите трёхзначное число для получения цифры во втором разряде: ");

            int numberScope;
            bool stringСheck;
            string number;

            do
            {
                Console.WriteLine("Введите трёхзначное число: ");
                number = Console.ReadLine()!;
                stringСheck = int.TryParse(number, out int num);
                numberScope = num;
            }
            while (stringСheck != true || number.Length != (numberScope < 0 ? 4 : 3));
            Console.WriteLine($"Второе число в трёхзначной цифре: {(Math.Abs(numberScope) / 10) % 10}");

        }
        public void ThirteenthTask()
        {
            Console.WriteLine("Задача #13 Введите число для получения цифры в третьем разряде (max/min - long): ");

            string stringNumber;
            bool stringСheck;
            long numberFromString;
            int stringLength;

            do
            {
                Console.WriteLine("Введите число: ");
                stringNumber = Console.ReadLine()!;
                stringLength = stringNumber.Length;
                stringСheck = long.TryParse(stringNumber, out long numberValue);
                numberFromString = numberValue;
                int stringLengthWithoutMinus = numberFromString < 0 ? stringLength - 1 : stringLength;
                long digit = 1;

                for (int i = 0; i < stringLengthWithoutMinus - 3; i++)
                {
                    digit *= 10;
                }

                if (numberValue > 99 || numberValue < -99)
                {
                    Console.WriteLine($"Третье число в цифре: {Math.Abs((numberValue / digit) % 10)}");
                }
                else if (stringСheck == true)
                {
                    Console.WriteLine($"Третьего числа нет");
                }
            }
            while (stringСheck != true || stringLength > (numberFromString < 0 ? 20 : 19) || (numberFromString == 0 && (stringLength > 19)));
        }
        public void FifteenthTask()
        {
            Console.WriteLine("Задача #15 Введите номер дня недели, для проверки является ли день выходным");
            string number;
            bool stringСheck;
            int nums;
            do
            {
                Console.WriteLine("Введите номер дня недели: ");
                number = Console.ReadLine()!;
                stringСheck = int.TryParse(number, out int num);
                nums = num;
                if (nums >= 1 && nums <= 7)
                {
                    Console.WriteLine((nums == 6 || nums == 7) ? "Выходной день" : "Будний день");
                }
            } while (stringСheck != true || nums < 1 || nums > 7);
        }
    }
}
