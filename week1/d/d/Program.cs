﻿using System;

namespace d
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //объявляем переменную(размер двумерного массива)
            string s;

            //считываем данные(размер двумерного массива) с кансоли
            s = Console.ReadLine();

            //преобразовываем данные из строки в тип данных integer
            int a = int.Parse(s);

            //создаем двумерный массив из а строк и а рядов
            int[,] arr = new int[a, a];

            //цикл для строк массива
            for (int i = 1; i <= a; i++)
            {
                //цикл для рядов массива
                for (int j = 1; j <= a; j++)
                {
                    /*
                     чтобы вывести треугольник, состоящий из звездочек
                     в нижем части массива, должно выполняться условие того,
                     что порядочный номер строки должен быть больше или равен 
                     номеру ряда массива
                     */
                    if (i >= j)
                    {
                        //выводим в кансоль звездочки
                        Console.Write("[*]");
                    }
                }
                //выводим пробел там, где не выполяется условие
                Console.WriteLine();
            }
        }
    }
}
