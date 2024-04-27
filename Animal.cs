using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    // Животное
    internal class Animal
    {
        Random random = new Random();
        public Animal(string name, string sound) 
        {
            InstanceCounter++;

            Gender = GetGender();
        }
        
        public static int InstanceCounter { get; private set; }

        public string Name { get; private set; }
        public string Gender { get; private set; }
        public string Sound { get; private set; }

        public void ShowInfo() 
        {
            Console.WriteLine($"Имя {Name} Пол{Gender} Звук{Sound}");
        }

        private string GetGender() 
        {
            int rundomNamber = random.Next(0,2);

            if (rundomNamber == 0)
            {
                return "Самец";
            }
            else
            {
                return "Самка";
            }
        }
    }
}
