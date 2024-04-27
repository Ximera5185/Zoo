using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Zoo
    {
        private List<Enclosure> _enclosures = new List<Enclosure>();

        private CreatorEnclosure _creatorEnclosure = new CreatorEnclosure();

        private CreatorAnimals _creatorAnimals = new CreatorAnimals();


        public Zoo()
        {
            AddEnclosures();
            Run();


        }

        private void Show() 
        {
            for (int i = 0; i < _enclosures.Count; i++)
            {
                Console.WriteLine($"{i+1} {_enclosures[i].Name}");
                
            }
        }
        private void AddEnclosures() 
        {
            int maxValue = 7;

            for (int i = 0; i < UserUtils.GetRandomNumber(0,maxValue); i++)
            {
                 _enclosures.Add(_creatorEnclosure.Create());
            }
        }
        private void Run()
        {
            const string CommandAddFish = "1";
            const string CommandRemoveFish = "2";
            const string CommandNextMove = "3";
            const string CommandExit = "4";

            string userCommand;

            bool isProgrammWorck = true;

            while (isProgrammWorck)
            {
                //Console.Clear();

                Show();

                Console.WriteLine($"В зоопарке {Enclosure.InstanceCounter} Вальеров\n" +
                $"\n" +
                $"Чтобы добавить рыбку нажмите {CommandAddFish}\n" +
                $"Чтобы достать рыбку введите {CommandRemoveFish}\n" +
                $"Сделать следующий ход {CommandNextMove}\n" +
                $"Выход из программы {CommandExit}");

                userCommand = Console.ReadLine();

                switch (userCommand)
                {
                    case CommandAddFish:
                       
                        break;

                    case CommandRemoveFish:
                       
                        break;

                    case CommandNextMove:
                        
                        break;

                    case CommandExit:
                        isProgrammWorck = false;
                        break;
                }
            }
        }

        private void ShowInfo() 
        {
            
        }
    }
}
