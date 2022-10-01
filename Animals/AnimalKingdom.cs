namespace Animals {
    public class AnimalKingdom {
        public AnimalKingdom() {
            InitializeKingdom();
        }

        private List<Animal> animals;
        public List<Animal> Animals {
            get {
                return animals;
            }
        }

        public void AddAnimal(Animal animal) {
            Animals.Add(animal);
        }

        private void InitializeKingdom() {
            animals = new List<Animal>();
        }

        public void ShowAnimals() {
            foreach (var animal in Animals) {
                Console.WriteLine("Class: {0}; Species: {1}", animal.AnimalClass, animal.AnimalSpecies);
            }
        }
    }
}
