using System;

namespace Task1
{
    class MainClass
    {
        //создаем функцию, которая возвращает true, false после выполнения условия 
        public static bool P(string str)
        {
            //объявляем переменные: начало слово и конец
            int i = 0;
            int j = str.Length - 1;

            //условие: пока i меньше j(пока отсчет дойдет до середины)
            while (i < j)
            {
                //если значение i-того и j-того элемента не равны, возвращать false
                if (str[i] != str[j])
                    return false;
                //увеличиваем значение i и уменьшаем j, чтобы проверить полностью слово
                i++;
                j--;
            }

            //если указанное выше условие не выполняется, возвращаем true
            return true;
        }

        public static void Main(string[] args)
        {
            //считываем с кансоли слово
            string s = Console.ReadLine();

            //присваиваем новой переменной функцию и передаем туда считанное слово
            bool a = P(s);

            //если условие выполнено, выводим "YES"
            if(a == true)
            {
                Console.WriteLine("Yes");
            }
            //в противном случае выводим "NO"
            else
            {
                Console.WriteLine("NO");

            }

        }
    }
}
