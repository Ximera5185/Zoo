using System.Collections.Generic;

namespace Zoo
{
    internal class CreatorEnclosure
    {
        private CreatorAnimals _creatorAnimals = new CreatorAnimals();

        private List<string> _names = new List<string>();

        public CreatorEnclosure() 
        {
            AddNames();
        }

        public Enclosure Create() 
        {
            string name = "";

            int index = UserUtils.GetRandomNumber(0,_names.Count);

            name = _names[index];

            _names.RemoveAt(index);

            return new Enclosure(name);
        }

        private void AddNames() 
        {
            _names = _creatorAnimals.GetTypes();
        }
    }
}