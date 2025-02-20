using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Zoo
{
    public class Cat : Animal
    {

        private bool HasClaws;

        public bool HasClaws1 { get => HasClaws; set => HasClaws = value; }

        public Cat(int id, string colour, bool hasFur, int noOfLegs, bool hasClaws)
            : base(id, colour, hasFur, noOfLegs)
        {
            this.HasClaws1 = hasClaws;
        }
        public Cat(bool hasClaws)
        {
            HasClaws1 = hasClaws;
        }

        public override void noise()
        {
            Console.WriteLine("Meow meow");
        }

        public override string ToString()
        {
            return $"Dog: \nID: {Id1}, \nColour: {Colour1}, \nDoes it have fur?: {HasFur1}, " +
                $"\nNumber of legs: {NoOfLegs1}, \nCat's name: {HasClaws1} ";
        }

    }
}
