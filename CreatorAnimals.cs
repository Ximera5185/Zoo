using System.Collections.Generic;

namespace Zoo
{
    internal class CreatorAnimals
    {
        private Dictionary<string, string> _sounds = new Dictionary<string, string>();

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
            _sounds.Add("Лев", "Рык");
            _sounds.Add("Волк", "Вой");
            _sounds.Add("Кабан", "Хрюканье");
            _sounds.Add("Рысь", "Рык");
            _sounds.Add("Лошадь", "Игого");
            _sounds.Add("Слон", "Ту-ду");
            _sounds.Add("Гипард", "Рык");
        }

        private string GetName(string enclosureName)
        {
            return _names [enclosureName];
        }

        private string GetSound(string name)
        {
            return _sounds [name];
        }
    }
}