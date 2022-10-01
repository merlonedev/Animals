// See https://aka.ms/new-console-template for more information
using Animals;

AnimalKingdom animalKingdom = new AnimalKingdom();

string newAnimal = "y";

void NewAnimal(string newAnimal) {
    while (newAnimal == "y") {
        Console.WriteLine("Add new animal? y/n");
        newAnimal = Console.ReadLine().ToLower();

        if (newAnimal == "n")
            break;

        Console.WriteLine("New animal class: ");
        string animalClass = Console.ReadLine()!;

        Console.WriteLine("New animal species: ");
        string animalSpecies = Console.ReadLine()!;

        Animal animal = new(animalClass, animalSpecies);

        animalKingdom.AddAnimal(animal);

    }
}

NewAnimal(newAnimal);

animalKingdom.ShowAnimals();
