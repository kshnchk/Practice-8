/*
Программа читает содержимое двух файлов (file1.txt и file2.txt) и записывает их в третий файл result.txt.
*/

namespace задание_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file1 = "file1.txt";
            string file2 = "file2.txt";
            string resF = "result.txt";

            string[] a = File.ReadAllLines(file1);
            string[] b = File.ReadAllLines(file2);

            string[] resab = new string[a.Length + b.Length];
            Array.Copy(a, resab, a.Length);
            Array.Copy(b, 0, resab, a.Length, b.Length);
            File.WriteAllLines(resF, resab);
            Console.WriteLine("Содержимое файлов успешно записано в " + resF);
        }
    }
}
