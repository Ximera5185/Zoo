using System;
using System.Collections.Generic;

namespace Zoo
{
    internal class Zoo
    {
        private List<Enclosure> _enclosures = new List<Enclosure>();

        private CreatorEnclosure _creatorEnclosure = new CreatorEnclosure();

        private CreatorAnimals _creatorAnimals = new CreatorAnimals();

        public Zoo()
        {
            AddEnclosures();

            Run();
        }

        private void Show()
        {
            for (int i = 0; i < _enclosures.Count; i++)
            {
                Console.WriteLine($"{i + 1} {_enclosures [i].Name}");
            }
        }
        private void AddEnclosures()
        {
            int minValue = 4;
            int maxValue = 7;

            for (int i = 0; i < UserUtils.GetRandomNumber(minValue, maxValue); i++)
            {
                _enclosures.Add(_creatorEnclosure.Create());
            }
        }
        private void Run()
        {
            const string CommandSelectionEnclosure = "1";
            const string CommandExit = "2";

            string userCommand;

            bool isProgrammWorck = true;

            while (isProgrammWorck)
            {
                Console.Clear();
                Console.WriteLine($"В зоопарке {Enclosure.InstanceCounter} Вальеров\n" +
                $"\n" +
                $"Чтобы перейти к вальерам введите  {CommandSelectionEnclosure}\n" +
                $"Выход из программы {CommandExit}");

                userCommand = Console.ReadLine();

                switch (userCommand)
                {
                    case CommandSelectionEnclosure:
                        Showenclosure();
                        break;

                    case CommandExit:
                        isProgrammWorck = false;
                        break;
                }
            }
        }

        private void Showenclosure()
        {
            Console.Clear();
                Show();

            int index = GetUserNumber("Введите порядковфй номер вальера");

            if (index < _enclosures.Count && index >= 0)
            {
                _enclosures [index].ShowAnimals();
            }
            else
            {
                Console.WriteLine("Нет такого порядкового номера, нажмите любую клавишу для продолжения");
                Console.ReadKey();
            }
        }

        private int GetUserNumber(string message)
        {
            int number = 0;

            string input = "";

                Console.WriteLine(message);

            while (int.TryParse(Console.ReadLine(), out number) == false)
            {

               // input = Console.ReadLine();

                Console.WriteLine("Вы ввели не целое число.");
                Console.WriteLine(message);
            }

            return number;
        }

    }
}