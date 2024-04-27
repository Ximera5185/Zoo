using System;

namespace Zoo
{
    internal class Animal
    {
        public Animal(string name, string sound)
        {
            Name = name;

            Sound = sound;

            Gender = GetGender();

            InstanceCounter++;
        }

        public static int InstanceCounter { get; private set; }

        public string Name { get; private set; }
        public string Gender { get; private set; }
        public string Sound { get; private set; }

        public void ShowInfo()
        {
            Console.WriteLine($"Имя-{Name} Пол-{Gender} Звук-{Sound}");
        }

        private string GetGender()
        {
            string [] genders = { "Самец", "Самка" };

            int randomNumber = UserUtils.GetRandomNumber(genders.Length);

            return genders[randomNumber];
        }
    }
}