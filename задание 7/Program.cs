/*
Пользователь вводит предложение. Программа считает количество слов (разделитель — пробел).
*/

namespace задание_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string inp = Console.ReadLine();
            string[] w = inp.Split(' ');
            int wc = w.Length;
            Console.WriteLine($"Количество слов в предложении: {wc}");
        }
    }
}
