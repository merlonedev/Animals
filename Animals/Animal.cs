namespace Animals {
    public class Animal {
        public string AnimalClass { get; set; } = "";

        public string AnimalSpecies { get; set; } = "";

        public Animal(string animalClass, string animalSpecies) {
            AnimalClass = animalClass;
            AnimalSpecies = animalSpecies;
        }
    }
}
