using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class CreatorAnimals
    {
        private AnimalSpecification _animalSpecification = new AnimalSpecification();
        

        public Animal CreateAnimal() 
        {
            string name = _animalSpecification.GetDataName();

            string sound = _animalSpecification.GetDataSound(name);

            return new Animal(name,sound);
        }

        

    }

}
