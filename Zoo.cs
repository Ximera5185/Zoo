using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Zoo
    {
        private CreatorAnimals _creatorAnimals = new CreatorAnimals();

        private CreatorEnclosure _creatorEnclosure = new CreatorEnclosure();

        public Zoo()
        {
            Run();
        }

        private void Run()
        {
            _creatorEnclosure.Create();
            _creatorEnclosure.Show();
        }
    }
}
