using System;

namespace Task2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
                string t = System.IO.File.ReadAllText(@"C:\Users\Desktop\fortask2\text.txt");
                string [] txt = t.Split();

                for (int i = 0; i < txt.Length; i++)
                {
                    int c = int.Parse(txt[i]);
                    int j;
                    for (j = 2; j < c; j++)
                        if ((c % j == 0))
                        {
                            break;
                        }


                    if (j == c)
                    {
                        System.IO.File.WriteAllText(@"C:\Users\Desktop\fortask2\output.txt", txt[i]);
                    }
                }
            }
    }
}
