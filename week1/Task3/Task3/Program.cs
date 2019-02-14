using System;

namespace Task3
{
    class MainClass
    {
        //создаем функцию которая будет выводить элемент два раза
        static void Double(string a)
        {
            for (int j = 0; j < 2; j++)
            {
                //вывод в кансоль элемент и пробел
                Console.Write(a + " ");
            }
        }

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
                //вызываем функцию
                Double(arr[i]);
            }
        }
    }
}
