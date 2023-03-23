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
            string userInputWord;
            string userInputMeanindOfWord;

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
                        Console.Clear();

                        if (dictionary.LongCount() == 0)
                        {
                            Console.WriteLine($"Словарь пустой, заполните словарь!");
                            Console.ReadKey();
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
                                Console.WriteLine("Нет такого слова");
                                Console.ReadKey();
                            }
                        }

                        break;

                    case ConsoleExit:
                        isWork = false;
                        break;

                    default:
                        break;
                }
            }
        }

        private static void AddWord(Dictionary<string, string> createDictionary)
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
    }
}   