using System;
using System.IO;
using System.Text;

namespace Lesson16
{
    class Program
    {
        static void Main(string[] args)
        {
            // Домашнее задание
            // Создать приложение, которое запрашивает данные пользователя
            // Записывает введенные данные в файл
            // По команде читает данные из файла

            Console.OutputEncoding = Encoding.UTF8;

            using (var sw = new StreamWriter("test.txt", false, Encoding.UTF8))
            {
                sw.WriteLine("Hello");
                sw.WriteLine("Hello, User");
                sw.WriteLine("Привет");
            }

            using (var sr = new StreamReader("test.txt", Encoding.UTF8))
            {
                while(!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine() + "конец строки");
                }

                sr.DiscardBufferedData();
                sr.BaseStream.Seek(0, SeekOrigin.Begin);

                var text = sr.ReadToEnd();
                Console.Write(text);
            }

            Console.ReadLine();
        }
    }
}
