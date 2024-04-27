using System;
using System.Collections.Generic;

namespace Zoo
{
    internal class Enclosure
    {
        private List<Animal> _animals = new List<Animal>();

        private CreatorAnimals _creatorAnimals = new CreatorAnimals();

        public Enclosure(string name)
        {
            int minValue = 1;
            int maxValue = 10;

            Name = name;

            AddAnimal(UserUtils.GetRandomNumber(minValue, maxValue));

            InstanceCounter++;
        }

        public static int InstanceCounter { get; private set; }

        public string Name { get; private set; }

        public void ShowAnimals()
        {
            Console.WriteLine($"В вальере {_animals.Count} зверей");

            foreach (Animal animal in _animals)
            {
                animal.ShowInfo();
            }

            Console.WriteLine("Чтоб отойти от вальера нажмите любую клавишу");
            Console.ReadKey();
        }

        private void AddAnimal(int numberAnimals)
        {
            for (int i = 0; i <= numberAnimals; i++)
            {
                _animals.Add(_creatorAnimals.CreateAnimal(Name));
            }
        }
    }
}