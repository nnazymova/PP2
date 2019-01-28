using System;

namespace b
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //объявляем первую переменную
            string n;

            //считываем с кансоли первую строку
            n = Console.ReadLine();

            //переобразовываем данные(размер массива) с считанной строки в тип данных integer
            int b = int.Parse(n);

            /*
              создаем массив, в основе которой лежит считанная строка с консоли, 
              разделенная на части по признаку(пробел) с помощью команды "Split"
            */
            string[] arr = Console.ReadLine().Split();

            //создаем цикл для массива с длинною б
            for (int i = 0; i < b; i++)
            {
                //вывод в кансоль два раза повторяющийся элемент, разделенный между собой пробелом
                Console.Write(arr[i] + " " + arr[i] + " ");
            }
        }
    }
}
