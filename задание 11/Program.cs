/*
Программа ищет в файле text.txt заданное пользователем слово и выводит количество его вхождений.
*/

using System.Text;

namespace задание_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFile = "text.txt";
            string wf;

            Console.Write("Введите слово для поиска: ");
            wf = Console.ReadLine();


            if (File.Exists(inputFile))
            {
                string text = File.ReadAllText(inputFile, Encoding.UTF8);
                int c = CountWords(text, wf);
                Console.WriteLine($"Слово \"{wf}\" встречается {c} раз(а) в файле \"{inputFile}\".");
            }
            else
            {
                Console.WriteLine("Файл не существует.");
            }
        }


        private static int CountWords(string t, string w)
        {
            string[] ws = t.Split(new char[] { ' ' });
            int c = -1;

            foreach (string str in ws)
            {

                c++;
            }

            return c;

        }
    }
}

