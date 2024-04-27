using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class CreatorAnimals
    {
        private Dictionary<string, string> _dataSounds = new Dictionary<string, string>();

        private List<string> _names = new List<string>();

        public CreatorAnimals() 
        {
            AddName();

            AddData();
        }
        public Animal CreateAnimal() 
        {
            string name = GetDataName();

            string sound = GetDataSound(name);

            return new Animal(name,sound);
        }

        private void AddName()
        {
            _names.Add("Лев");
            _names.Add("Волк");
            _names.Add("Кабан");
            _names.Add("Рысь");
            _names.Add("Лошадь");
            _names.Add("Слон");
            _names.Add("Гипард");
        }
        private void AddData()
        {
            _dataSounds.Add("Лев", "Рык");
            _dataSounds.Add("Волк", "Вой");
            _dataSounds.Add("Кабан", "Хрюканье");
            _dataSounds.Add("Рысь", "Рык");
            _dataSounds.Add("Лошадь", "Игого");
            _dataSounds.Add("Слон", "Ту-ду");
            _dataSounds.Add("Гипард", "Рык");
        }

        private string GetDataName()
        {
            int minValue = 0;

            return _names [UserUtils.GetRandomNumber(minValue, _names.Count)];
        }

        private string GetDataSound(string name)
        {
            return _dataSounds [name];
        }

    }

}
