using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
// спецификация зверей
    internal class AnimalSpecification
    {
        private Dictionary<string,string> _dataSound = new Dictionary<string,string>();

        private List<string> _name = new List<string>();

      public  AnimalSpecification() 
        {
            AddName();
            AddData();
        }

        private void AddName() 
        {
            _name.Add("Лев");
            _name.Add("Волк");
            _name.Add("Кабан");
            _name.Add("Рысь");
            _name.Add("Лошадь");
            _name.Add("Слон");
            _name.Add("Гипард");
        }
        private void AddData() 
        {
            _dataSound.Add("Лев","Рык");
            _dataSound.Add("Волк", "Вой");
            _dataSound.Add("Кабан", "Хрюканье");
            _dataSound.Add("Рысь", "Рык");
            _dataSound.Add("Лошадь", "Игого");
            _dataSound.Add("Слон", "Ту-ду");
            _dataSound.Add("Гипард", "Рык");
        }

        public string GetDataName() 
        {
            Random random = new Random();

            return _name [random.Next(0,_name.Count)];
        }

        public string GetDataSound(string name) 
        {
            return _dataSound [name];
        }
    }
}
