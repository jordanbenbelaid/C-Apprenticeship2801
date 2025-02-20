namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal Lion = new Animal(1, "orangey brown", true, 4);
            Animal Tiger = new Animal(3, "Orange and black", true, 4);
            Animal Elephant = new Animal(5, "Grey", false, 4);
            Animal Cow = new Animal(7, "Black and white", false, 4);

            Dog GermanShepherd = new Dog(2, "Black", true, 4, "doggo");
            Dog Doberman = new Dog(4, "black and brown", false, 4, "doge");
            Dog Rottweiler = new Dog(6, "black and brown", true, 4, "doggy");
            Dog Labrador = new Dog(8, "white", true, 4, "dog");

            Zoo zoo = new Zoo();
            zoo.AddAnimalToList(Lion);
            zoo.AddAnimalToList(Tiger);
            zoo.AddAnimalToList(Elephant);
            zoo.AddAnimalToList(Cow);
            zoo.AddAnimalToList(GermanShepherd);
            zoo.AddAnimalToList(Doberman);
            zoo.AddAnimalToList(Rottweiler);
            zoo.AddAnimalToList(Labrador);


            List<Animal> dogs = zoo.FindAnimalByType(typeof(Dog));

            Console.WriteLine("\n\nDogs in the zoo:");
            foreach (var animal in dogs)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
