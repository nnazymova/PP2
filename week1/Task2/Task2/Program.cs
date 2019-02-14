using System;

namespace Task2
{
    //создаем новый класс под названием Student
    class Student
    {
        //создаем переменные 
        public string name;
        public string id;
        public int year;

        //создаем конструктор, который будет принимать два значения
        public Student(string name, string id)
        {
            this.name = name;
            this.id = id;
        }

        //создаем функцию, которая будет возвращать имя 
        public string GetName()
        {
            return name;
        }

        //создаем функцию, которая будет возвращать айди 
        public string GetId()
        {
            return id;
        }

        //создаем функцию, которая будет увеличивать год обучения
        public int GetYear()
        {
            return ++year;
        }
    }


    class MainClass
    {
        static void Main(string[] args)
        {

            //считваем с кансоли данные
            Student Info = new Student("Nazerke", "18BD111074");

            //создаем цикл, который будет повторяться 4 раза(4 года обучения)
            for (int i = 0; i < 4; i++)
            {
                //вызываем функцию, которая будет возвращать имя 
                Console.WriteLine(Info.GetName());

                //вызываем функцию, которая будет возвращать айди
                Console.WriteLine(Info.GetId());

                //вызываем функцию, которая будет возвраащать увеличенный год обучения
                Console.WriteLine(Info.GetYear());
            }
        }
    }
}
