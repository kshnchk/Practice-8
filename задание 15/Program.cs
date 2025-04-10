/*
Программа читает файл book.txt и выводит статистику: количество символов, слов и строк.
*/

namespace задание_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string f = "book.txt";
            string c = File.ReadAllText(f);
            int cc = c.Length;
            int wc = 0;
            bool iw = false;

            foreach (char ch in c)
            {

                if (ch == ' ')
                {
                    if (iw)
                    {
                        iw = false;
                    }
                }
                else
                {
                    if (!iw)
                    {
                        iw = true;
                        wc++;
                    }
                }
            }


            int lc = 0;

            foreach (char ch in c)
            {
                if (ch == '\n')
                {
                    lc++;
                }
            }

            Console.WriteLine($"Количество символов: {cc}");
            Console.WriteLine($"Количество слов: {wc}");
            Console.WriteLine($"Количество строк: {lc}");
        }
    }
}
