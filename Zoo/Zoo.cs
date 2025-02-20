using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Zoo
    {

        private List<Animal> animals;
        public Zoo() { this.animals = new List<Animal>(); }

        public void AddAnimalToList(Animal animal)
        {
            this.animals.Add(animal);
        }

        public Animal FindAnimalById(int id)
        {
            foreach (Animal a in this.animals)
            {
                if (a.Id1 == id)
                {
                    return a;
                }
            }
            throw new AnimalNotFoundException($"The animal with the ID of {id} could not be found");
        }

        public List<Animal> FindAnimalByType(Type type)
        {
            return animals.Where(a => a.GetType() == type).ToList();
        }
    }
}
