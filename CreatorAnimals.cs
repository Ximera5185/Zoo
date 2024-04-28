using System.Collections.Generic;
using System.Linq;

namespace Zoo
{
    internal class CreatorAnimals
    {
        private Dictionary<string,Animal> _types = new Dictionary<string,Animal>();

        public CreatorAnimals() 
        {
            FillTypes();
        }

        public Animal CreateAnimal(string enclosureName) 
        {
            return new Animal(_types [enclosureName].Name, _types [enclosureName].Sound);
        }

        public List<string> GetTypes() 
        {
            return _types.Keys.ToList();
        }

        private void FillTypes() 
        {
            _types.Add("Львы", new Animal("Лев", "Рык"));
            _types.Add("Волки", new Animal("Волк", "Вой"));
            _types.Add("Кабаны", new Animal("Кабан", "Хрюканье"));
            _types.Add("Рыси", new Animal("Рысь", "Рык"));
            _types.Add("Лошади", new Animal("Лошадь", "Игого"));
            _types.Add("Слоны", new Animal("Слон", "Ту-ду"));
            _types.Add("Гипарды", new Animal("Гипард", "Рык"));
        }
    }
}