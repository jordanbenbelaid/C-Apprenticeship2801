using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class AnimalNotFoundException : Exception
    {

        public AnimalNotFoundException() : base("Animal not found") { }

        public AnimalNotFoundException(string message) : base(message) { }

    }
}
