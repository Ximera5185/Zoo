using System.Collections.Generic;

namespace Zoo
{
    internal class CreatorAnimals
    {
        private Dictionary<string, string> _dataSounds = new Dictionary<string, string>();

        private Dictionary<string, string> _names = new Dictionary<string, string>();

        public CreatorAnimals() 
        {
            AddName();

            AddSound();
        }
        public Animal CreateAnimal(string enclosureName) 
        {
            string name = GetName(enclosureName);

            string sound = GetSound(name);

            return new Animal(name,sound);
        }

        private void AddName()
        {
            _names.Add("Львы","Лев");
            _names.Add("Волки", "Волк");
            _names.Add("Кабаны", "Кабан");
            _names.Add("Рыси", "Рысь");
            _names.Add("Лошади", "Лошадь");
            _names.Add("Слоны", "Слон");
            _names.Add("Гипарды", "Гипард");
        }

        private void AddSound()
        {
            _dataSounds.Add("Лев", "Рык");
            _dataSounds.Add("Волк", "Вой");
            _dataSounds.Add("Кабан", "Хрюканье");
            _dataSounds.Add("Рысь", "Рык");
            _dataSounds.Add("Лошадь", "Игого");
            _dataSounds.Add("Слон", "Ту-ду");
            _dataSounds.Add("Гипард", "Рык");
        }

        private string GetName(string enclosureName)
        {
            return _names [enclosureName];
        }

        private string GetSound(string name)
        {
            return _dataSounds [name];
        }
    }
}