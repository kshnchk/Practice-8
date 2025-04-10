/*
Пользователь вводит символ. Программа выводит его код.
*/

namespace задание_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите символ: ");
            char c = Console.ReadLine()[0];
            Console.WriteLine($"Код символа: {(int)c}");
        }
    }
}
