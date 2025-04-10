/*
Пользователь вводит символ. Программа определяет, является ли он
цифрой, буквой или спецсимволом, и выводит результат.
*/

namespace задание_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите символ: ");
            char c = Console.ReadLine()[0];

            if (char.IsDigit(c))
                Console.WriteLine("Это цифра.");
            else if (char.IsLetter(c))
                Console.WriteLine("Это буква.");
            else
                Console.WriteLine("Это специальный символ.");
        }
    }
}
