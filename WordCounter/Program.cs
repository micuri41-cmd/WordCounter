
using System;

namespace WordCounter
{
    public class Program
    {
        // Метод для подсчёта слов в строке
        public static int CountWords(string text)
        {
            // Проверяем, пустая ли строка
            if (string.IsNullOrWhiteSpace(text))
            {
                return 0;
            }

            // Разделяем строку на слова
            string[] words = text.Split(
                ' ',
                StringSplitOptions.RemoveEmptyEntries
            );

            // Возвращаем количество слов
            return words.Length;
        }

        // Главный метод программы
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");

            string text = Console.ReadLine() ?? "";

            int result = CountWords(text);

            Console.WriteLine("Количество слов: " + result);
        }
    }
}
