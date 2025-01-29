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


        public override string ToString()
        {
            return $"Dog: \nID: {Id1}, \nColour: {Colour1}, \nDoes it have fur?: {HasFur1}, " +
                $"\nNumber of legs: {NoOfLegs1}, \nDog's name: {Name1} ";
        }
    }
}
