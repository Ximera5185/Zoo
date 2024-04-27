using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Zoo
{
    internal class CreatorEnclosure
    {
        private List<string> _enclosureTypes = new List<string>();

        public CreatorEnclosure() 
        {
            AddTypes();
        }

        public Enclosure Create() 
        {
            string name = "";

            int index = UserUtils.GetRandomNumber(0,_enclosureTypes.Count);

            name = _enclosureTypes[index];

            _enclosureTypes.RemoveAt(index);

            return new Enclosure(name);
        }

        private void AddTypes() 
        {
            _enclosureTypes.Add("Львы");
            _enclosureTypes.Add("Волки");
            _enclosureTypes.Add("Кабаны");
            _enclosureTypes.Add("Рыси");
            _enclosureTypes.Add("Лошади");
            _enclosureTypes.Add("Слоны");
            _enclosureTypes.Add("Гипарды");
        }
    }
}
