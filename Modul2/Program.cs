using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            Console.WriteLine("Дано выражение y=7x^2-3x+4");
            Console.Write("Введите значение х: ");

            int x = int.Parse(Console.ReadLine());
            var y = (7 * Math.Pow(4, 2)) - (3 * x) + 4;

            Console.WriteLine("Ответ:\n " + "7*" + x + "^2" + "-3*" + x + "+4 = " + y);


            //Задание 2
            const double PI = 3.14;

            Console.Write("Введите радиус окружности(cm): ");
            int r = int.Parse(Console.ReadLine());

            Console.WriteLine("Длина окружности - " + 2 * PI * r + " cm");
            Console.Write("Площадь круга - " + PI * Math.Pow(r, 2) + " cm2");

            //Задание 3
            int cmInMeter = 100;

            Console.Write("Введите расстояние в см: ");
            int distance = int.Parse(Console.ReadLine());

            int meter = distance / cmInMeter;
            Console.Write("Сдесь " + meter + " метров");

            //Задание 4
            int days = 7;
            int afterMoment = 234;

            Console.WriteLine("C 01.04.2017 прошло 234 дня");

            int week = afterMoment / days;
            Console.Write("Всего недель прошло - " + week);

            //Задание 5
            int dozenNum;
            int unitsNum;
            int sumNum;
            int productNum;

            Console.Write("Введите двузначное число: ");
            int doubleDigitNum = int.Parse(Console.ReadLine());

            dozenNum = doubleDigitNum / 10;
            unitsNum = doubleDigitNum % 10;
            sumNum = dozenNum + unitsNum;
            productNum = dozenNum * unitsNum;

            Console.WriteLine("Число десятков: " + dozenNum);
            Console.WriteLine("Число едицин: " + unitsNum);
            Console.WriteLine("Сумма цифр: " + sumNum);
            Console.WriteLine("Произведение цифр: " + productNum);

            //Задание 6
            int thousandNumber;
            int hundredNumber;
            int dozenNumber;
            int unitsNumber;
            int sumNumber;
            int productNumber;
            int tempHundredNum;
            int tempDozenNum;

            Console.Write("Введите четырехзначное число: ");
            int fourDigitNumber = int.Parse(Console.ReadLine());

            thousandNumber = fourDigitNumber / 1000;

            tempHundredNum = fourDigitNumber % 1000;
            hundredNumber = tempHundredNum / 100;

            tempDozenNum = tempHundredNum % 100;
            dozenNumber = tempDozenNum / 10;

            unitsNumber = tempDozenNum % 10;

            sumNumber = thousandNumber + hundredNumber + dozenNumber + unitsNumber;
            productNumber = thousandNumber * hundredNumber * dozenNumber * unitsNumber;

            Console.WriteLine("Сумма цифр: " + sumNumber);
            Console.WriteLine("Произведение цифр: " + productNumber);

            Console.ReadLine();
        }
    }
}
