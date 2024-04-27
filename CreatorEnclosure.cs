using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class CreatorEnclosure
    {
        private List<Enclosure> _enclosures = new List<Enclosure>();

        private Enclosure _enclosure;
        public void Create() 
        {
            Random random = new Random();

            for (int i = 0; i < random.Next(4,10); i++)
            {
                _enclosures.Add(_enclosure = new Enclosure());
                
            }
        }


        public void Show() 
        {
            foreach (Enclosure enclosure in _enclosures)
            {
                enclosure.ShowAnimals();
            }
        }
        
    }
}
