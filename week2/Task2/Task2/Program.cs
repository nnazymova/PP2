using System;
using System.IO;

namespace Task2
{
    class MainClass
    {
        static bool IsPrime(int p)
        {
            //если наше число p будет равным 1, возвращаем false
            if (p == 1)
                return false;

            //создаем цикл, начинающий с 2 до нашего числа, потому что условие с единицой уже рассмотрено
            for (int k = 2; k < p; k++)
            {
                //возвращем false, если наше число при делении на делитель остается без остатка
                if (p % k == 0)
                    return false;
            }
            //возвращем true, если все предыдущие условия не выполняются
            return true;
        }

        public static void Main(string[] args)
        {
            //создаем DirectoryInfo чтобы указать путь к нашим файлам
            DirectoryInfo d = new DirectoryInfo(@"/Users/naz/desktop/pp2/week2");

            //создаем StreamReader чтобы считать из файла text.txt
            StreamReader sr = new StreamReader("text.txt");

            //создаем StreamWriter чтобы написать в файл output.txt
            StreamWriter sw = new StreamWriter("output.txt");

            //создаем переменную, основой которой будет считанная строка из файла
            String s = sr.ReadLine();

            //создаем новый массив, основой которой будут считанные числа, разделенные между собой с помощью пробела
            string [] txt = s.Split();

            //создаем цикл для проверки цисел 
            for (int i = 0; i < txt.Length; i++)
                {
                    //преобразовываем каждое число в тип данных integer
                    int c = int.Parse(txt[i]);

                //условие: если функция возвращает true
                if (IsPrime(c) == true)
                {
                    //то записываем данное число в файл 
                    sw.Write(c + " ");
                }

            }

            //закрываем использованные файлы
            sr.Close();
            sw.Close();
        }
    }

}
