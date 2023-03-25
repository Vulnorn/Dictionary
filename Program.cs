using System;
using System.Collections.Generic;
using System.Linq;

namespace Biblioteka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int ConsoleAddWord = 1;
            const int ConsoleOutputMeaningOfWord = 2;
            const int ConsoleExit = 3;

            bool isWork = true;
            int userChoice;

            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            while (isWork)
            {
                Console.Clear();
                Console.WriteLine($"\n{ConsoleAddWord}. Добавить слово со значением. \n\n{ConsoleOutputMeaningOfWord}. Вывести значение для слова.\n\n{ConsoleExit}. Выход.");
                userChoice = Convert.ToInt32(Console.ReadLine());

                switch (userChoice)
                {
                    case ConsoleAddWord:
                        AddWord(dictionary);
                        break;

                    case ConsoleOutputMeaningOfWord:
                        FindMeaningOfWord(dictionary);
                        break;

                    case ConsoleExit:
                        isWork = false;
                        break;

                    default:
                        ReportAnError("");
                        break;
                }
            }
        }

        static void AddWord(Dictionary<string, string> dictionary)
        {
            string userCreateWord;
            string userCreateMeanindOfWord;

            Console.Clear();
            Console.WriteLine($"Введите слово:");
            userCreateWord = Console.ReadLine();
            if (dictionary.ContainsKey(userCreateWord))
            {
                ReportAnError("Такое слово уже существует.");
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"Введите значение для этого слова:");
                userCreateMeanindOfWord = Console.ReadLine();
                dictionary.Add(userCreateWord, userCreateMeanindOfWord);
            }
        }

        static void FindMeaningOfWord(Dictionary<string, string> dictionary)
        {
            string userInputWord;

            Console.Clear();

            if (dictionary.LongCount() == 0)
            {
                ReportAnError("Словарь пустой, заполните словарь!");
            }
            else
            {
                Console.Write($"Показать значение слова: ");
                userInputWord = Console.ReadLine();

                if (dictionary.ContainsKey(userInputWord))
                {
                    Console.Write($"\\n{dictionary[userInputWord]}");
                    Console.ReadKey();
                }
                else
                {
                    ReportAnError("Нет такого слова");
                }
            }
        }
        static void ReportAnError(string causeOfError)
        {
            Console.WriteLine($"Ошибка ввода. {causeOfError}");
            Console.ReadKey();
        }
    }
}