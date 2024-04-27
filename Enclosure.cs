using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
// Вальер
    internal class Enclosure
    {
       private List<Animal> _animals = new List<Animal>();

       private CreatorAnimals _creatorAnimals = new CreatorAnimals();
       Random random = new Random();
       public Enclosure() 
       {
            AddAnimal(random.Next(1,10));
       }
        public int Capacity { get; private set; }

        public void ShowAnimals() 
        {
            Console.WriteLine($"В вальере {_animals.Count} зверей");

            foreach (Animal animal in _animals)
            {
                animal.ShowInfo();   
            }
        }

        private void AddAnimal(int numberAnimals) 
        {
            for (int i = 0; i <= numberAnimals; i++)
            {
                _animals.Add(_creatorAnimals.CreateAnimal());
            }
        }
    }
}
