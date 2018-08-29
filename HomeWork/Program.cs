using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1
            int num1 = 151551;
            int num2 = 45542;
            int num3 = 441785;

            Console.WriteLine("{0}  {1}  {2}\n", num1, num2, num3);

            //Task2
            Console.WriteLine("5\n10\n21");

            //Task3
            int cmInMeter = 100;

            Console.Write("Введите расстояние в см: ");
            int distance = int.Parse(Console.ReadLine());

            int meter = distance / cmInMeter;
            Console.Write("Сдесь " + meter + " метров");

            //Task4
            int days = 7;
            int afterMoment = 234;

            Console.WriteLine("C 01.04.2017 прошло 234 дня");

            int week = afterMoment / days;
            Console.Write("Всего недель прошло - " + week);

            //Task5
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

            //Task6
            Console.WriteLine("A - true, B - false, C - falce");
            bool A = true;
            bool B = false;
            bool C = false;
            bool a = A || B;
            bool b = A && B;
            bool c = B || C;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);

            //Task7
            Console.WriteLine("Введите радиус круга: ");
            int rad = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите cторонy квадрата: ");
            int side = int.Parse(Console.ReadLine());

            var circle = 2 * 3.14 * rad;
            var square = Math.Pow(side, 2);

            Console.WriteLine("Площадь круга: " + circle);
            Console.WriteLine("Площадь квадрата: " + square);

            if (circle < square)
            {
                Console.WriteLine("\nПлощадь квадрата больше!");
            }
            else
                Console.WriteLine("Площадь круга больше!");

            //Task8
            Console.Write("Введите вид 1 материала: ");
            string material = Console.ReadLine();

            Console.Write("Введите массу: ");
            var mass1 = int.Parse(Console.ReadLine());

            Console.Write("Введите объем: ");
            var volume1 = int.Parse(Console.ReadLine());

            Console.Write("Введите вид 2 материала: ");
            string materia2 = Console.ReadLine();

            Console.Write("Введите массу: ");
            var mass2 = int.Parse(Console.ReadLine());

            Console.Write("Введите объем: ");
            var volume2 = int.Parse(Console.ReadLine());

            double density1 = mass1 / volume1;
            double density2 = mass2 / volume2;

            Console.WriteLine("Плотность 1 материала: " + density1 + " кг/м3");
            Console.WriteLine("Плотность 2 материала: " + density2 + " кг/м3");

            if (density1 > density2)
            {
                Console.WriteLine("Плотность 1 материала больше!");
            }
            else
            {
                Console.WriteLine("Плотность 2 материала больше!");
            }

            //Task10
            for (int i = 20; i < 36; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();

            Console.Write("Введите предел чисел для возведения в квадрат: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 10; i < x + 1; i++)
            {
                Console.Write(i + "^2 = " + Math.Pow(i, 2) + "\n");
            }

            Console.ReadKey();

            Console.Write("Введите число старта для возведения в 3 степень: ");
            int y = int.Parse(Console.ReadLine());

            for (int i = y; i != 51; i++)
            {
                Console.Write(i + "^3 = " + Math.Pow(i, 3) + "\n");
            }

            Console.ReadKey();

            Console.Write("Введите начало цифр: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Введите конец цифр: ");
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i < end + 1; i++)
            {
                Console.Write(i + "\n");
            }


            Console.ReadLine();
        }
    }
}
