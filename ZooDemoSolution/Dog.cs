using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooDemoSolution
{
    public class Dog : Animal
    {
        private string Name;

        public string Name1 { get => Name; set => Name = value; }

        public Dog(int id, string colour, bool hasFur, int noOfLegs, string name)
            : base(id, colour, hasFur, noOfLegs)
        {
            this.Name1 = name;
        }

        public Dog(string name)
        {
            this.Name1 = name;
        }

        //In the Animal class, we have a noise method. We have to add the keyword "virtual"
        //This allows us to then override the method in the Parent/Base class
        //and we can add our own implementation specifically for Dog
        public override void noise()
        {
            Console.WriteLine("Woof Bark");
        }

        //This is an example of method overloading
        //We use the same method name, but add different parameters to each
        //c# recognises this and allows us to have it as 2 different methods
        //Normally having the same method name is not allowed, unless they have different parameters
        public void eat()
        {
            Console.WriteLine("This food is good!");
        }

        public void eat(string food)
        {
            Console.WriteLine($"This {food} is good!");
        }


        public override string ToString()
        {
            return $"Dog: \nID: {Id1}, \nColour: {Colour1}, \nDoes it have fur?: {HasFur1}, " +
                $"\nNumber of legs: {NoOfLegs1}, \nDog's name: {Name1} ";
        }
    }
}
