using System.Collections;
using System.Collections.ObjectModel;

namespace Task_1
{
    public class AnimalCollection
    {
        private Collection<Animal> _animals;

        public AnimalCollection(Zoo zoo)
        {
            _animals = new Collection<Animal>();
            Zoo = zoo;
        }

        public Zoo Zoo {  get; private set; }

        public void Add(Animal animal)
        {
            if(animal.Zoo != null && animal.Zoo != Zoo)
            {
                animal.Zoo.Animals.Remove(animal);
            }
            animal.Zoo = Zoo;
            _animals.Add(animal);
        }

        public void Remove(Animal animal)
        {
            if (animal.Zoo != Zoo)
                throw new InvalidOperationException($"{nameof(AnimalCollection)} does not contain element {animal}");

            animal.Zoo = null;
            _animals.Remove(animal);
        }

        public IEnumerator GetEnumerator()
        {
            return _animals.GetEnumerator();
        }
    }
}
