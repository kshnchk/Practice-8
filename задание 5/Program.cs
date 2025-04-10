/*
Переворот строки.
*/

namespace задание_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string s = Console.ReadLine();
            string rever = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                rever += s[i];
            }
            Console.WriteLine(rever);
        }
    }
}
