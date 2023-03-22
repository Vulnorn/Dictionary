using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
//Создать программу, которая принимает от пользователя слово и выводит его значение. Если такого слова нет, то следует вывести соответствующее сообщение.

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
            string word;
            string meanindOfWord;

            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            while (isWork)
            {
                Console.Clear();
                Console.CursorVisible = false;
                Console.WriteLine($"\n{ConsoleAddWord}. Добавить слово со значением. \n\n{ConsoleOutputMeaningOfWord}. Вывести значение для слова.\n\n{ConsoleExit}. Выход.");
                userChoice = Convert.ToInt32(Console.ReadLine());

                switch (userChoice)
                {
                    case ConsoleAddWord:
                        Console.Clear();
                        Console.WriteLine($"Введите слово:");
                        userInputWord = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine($"Введите значение для этого слова:");
                        userInputMeanindOfWord = Console.ReadLine();
                        dictionary.Add(userInputWord, userInputMeanindOfWord);
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
                            }
                            else
                            {
                                Console.WriteLine("Нет такого слова");
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
    }
}