using System;
using System.IO;

namespace Task4
{
    class MainClass
    {
        public static void Copy()
        {
            //задаем путь для первого файла
            string path = "/Users/naz/desktop/fortask3";

            //задаем путь для второго файла(его копии)
            string path1 = "/Users/naz/desktop/fortask3/f3";

            //объявляем новые файлы и указываем путь для них
            string text = Path.Combine(path, "text.txt");
            string copy = Path.Combine(path1, "copy.txt");

            //создаем первый файл
            File.Create(text);

            //создаем ее копию
            File.Copy(text, copy, true);

            //удаляем оригинал
            File.Delete(text);
        }

        public static void Main(string[] args)
        {
            //вызываем функцию
            Copy();
        }
    }
}
