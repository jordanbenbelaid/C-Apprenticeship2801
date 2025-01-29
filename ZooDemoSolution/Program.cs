namespace ZooDemoSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal lion = new Animal(1, "orangey brown", true, 4);

            //using the generated getters and setters, we use the generated name, if we want to get,
            //we use the name of the object we created with the generated method name
            //Console.WriteLine(lion.Colour1);
            //lion.Colour1 = "Brown";

            Dog dog = new Dog(2, "Black", true, 4, "Saffron");

            Cat cat = new Cat(3, "white", false, 4, true);

            Console.WriteLine(dog);

            dog.noise();

            Zoo zoo = new Zoo();
            

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
