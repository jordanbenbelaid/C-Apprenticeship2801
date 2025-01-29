namespace ZooDemoSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //using the generated getters and setters, we use the generated name, if we want to get,
            //we use the name of the object we created with the generated method name
            //Console.WriteLine(lion.Colour1);
            //lion.Colour1 = "Brown";

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


            //Encapsulate fields (and use properties):
            //We access fields through properties (The generated getters and setters)
            //allows logic (validation etc) in the getters and setters
            //Flexible as it allows us to easily change implementation without breaking code
            //Can be a little slower due to the way it calls methods

            //Encapsulate fields (but using fields):
            //we access directly from fields or getter and setter methods
            //We have less control over how data is modified/accessed
            //harder to change data access (manual refactoring)
            //slightly faster, since its direct access


        }
    }
}
