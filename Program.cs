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
                        break;
                }
            }
        }

        static void AddWord(Dictionary<string, string> createDictionary)
        {
            string userCreateWord;
            string userCreateMeanindOfWord;

            Console.Clear();
            Console.WriteLine($"Введите слово:");
            userCreateWord = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Введите значение для этого слова:");
            userCreateMeanindOfWord = Console.ReadLine();
            createDictionary.Add(userCreateWord, userCreateMeanindOfWord);
        }

        static void FindMeaningOfWord(Dictionary<string, string> createDictionary)
        {
            string userInputWord;

            Console.Clear();

            if (createDictionary.LongCount() == 0)
            {
                Console.WriteLine($"Словарь пустой, заполните словарь!");
                Console.ReadKey();
            }
            else
            {
                Console.Write($"Показать значение слова: ");
                userInputWord = Console.ReadLine();

                if (createDictionary.ContainsKey(userInputWord))
                {
                    Console.Write($"\\n{createDictionary[userInputWord]}");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Нет такого слова");
                    Console.ReadKey();
                }
            }
        }
    }
}