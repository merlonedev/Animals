namespace Animals {
    internal class AnimalClass {
        public AnimalClass() {
            InitializeClasses();
        }

        public List<string> AnimalClasses { get; set; }

        public void AddAnimalClass(string animalClass) {
            AnimalClasses.Add(animalClass);
        }

        private void InitializeClasses() {
            AnimalClasses = new List<string>();
        }
    }
}
