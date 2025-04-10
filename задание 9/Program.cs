/*
Пользователь вводит строку и две подстроки: что заменить и на что.
Программа заменяет все вхождения и выводит результат.
*/

namespace задание_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string s = Console.ReadLine();
            Console.Write("Введите подстроку для замены: ");
            string chS = Console.ReadLine();
            Console.Write("Введите новую подстроку: ");
            string newS = Console.ReadLine();
            string res = s.Replace(chS, newS);
            Console.WriteLine(res);
        }
    }
}
