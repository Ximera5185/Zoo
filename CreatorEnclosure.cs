using System.Collections.Generic;

namespace Zoo
{
    internal class CreatorEnclosure
    {
        private List<string> _names = new List<string>();

        public CreatorEnclosure() 
        {
            AddName();
        }

        public Enclosure Create() 
        {
            string name = "";

            int index = UserUtils.GetRandomNumber(0,_names.Count);

            name = _names[index];

            _names.RemoveAt(index);

            return new Enclosure(name);
        }

        private void AddName() 
        {
            _names.Add("Львы");
            _names.Add("Волки");
            _names.Add("Кабаны");
            _names.Add("Рыси");
            _names.Add("Лошади");
            _names.Add("Слоны");
            _names.Add("Гипарды");
        }
    }
}