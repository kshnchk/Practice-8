/*
Пользователь вводит математическое выражение (например, "2+3*4"). Программа вычисляет результат и выводит его.
*/

namespace задание_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Введите математическое выражение(Нельзя делить на 0): ");
                string e = Console.ReadLine();

                int r = EvaluateExpression(e);

                Console.WriteLine($"Результат: {r}");
            }

            static int EvaluateExpression(string e)
            {
                int r = 0;
                char o = '+';
                string n = "";

                for (int i = 0; i < e.Length; i++)
                {
                    char c = e[i];

                    if (char.IsDigit(c))
                    {
                        n += c;
                    }

                    if (i == e.Length - 1 || c == '+' || c == '-' || c == '*' || c == '/')
                    {

                        int num = int.Parse(n);


                        switch (o)
                        {
                            case '+':
                                r += num;
                                break;
                            case '-':
                                r -= num;
                                break;
                            case '*':
                                r = (r == 0) ? num : r * num;
                                break;
                            case '/':
                                r = (r == 0) ? num : r / num;
                                break;
                        }

                        o = c;
                        n = "";
                    }
                }

                return r;
            }
        }
    }
}
