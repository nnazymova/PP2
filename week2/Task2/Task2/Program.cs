using System;
using System.IO;

namespace Task2
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo("/Users/naz/desktop/pp2/week2/Task2");
            StreamReader sr = new StreamReader("input.txt");
            String s = sr.ReadToEnd();
            string [] txt = s.Split();

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
                    StreamWriter sw = new StreamWriter("output.txt");
                    sw.WriteLine(c);
                }
                }
            }
    }
}
