using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ZooDemoSolution
{
    public class Animal
    {

        private int Id;
        private string Colour;
        private bool HasFur;
        private int NoOfLegs;

        public Animal(int id, string colour, bool hasFur, int noOfLegs)
        {
            this.Id1 = id;
            this.Colour1 = colour;
            this.HasFur1 = hasFur;
            this.NoOfLegs1 = noOfLegs;
        }

        public Animal() { }

        public int Id1 { get => Id; set => Id = value; }
        public string Colour1 { get => Colour; set => Colour = value; }
        public bool HasFur1 { get => HasFur; set => HasFur = value; }
        public int NoOfLegs1 { get => NoOfLegs; set => NoOfLegs = value; }


        //public int getId()
        //{
        //    return Id;
        //}

        //public void setId(int id)
        //{
        //    this.Id = id;
        //}

        //public string getColour()
        //{
        //    return this.Colour;
        //}

        //public void setColour(string colour)
        //{
        //    this.Colour = colour;
        //}

        //public bool isHasFur()
        //{
        //    return HasFur;
        //}

        //public void setHasFur(bool hasFur)
        //{
        //    this.HasFur = hasFur;
        //}

        //public int getNoOfLegs()
        //{
        //    return NoOfLegs;
        //}

        //public void setNoOfLegs(int noOfLegs)
        //{
        //    this.NoOfLegs = noOfLegs;
        //}

        //Any other methods
        public void noise()
        {
            Console.WriteLine("Animal noise");
        }

        //public override string ToString()
        //{
        //    return "Animal - id: " + Id1 + ", \nColour: " + Colour1 + ", \nHas Fur: "
        //        + HasFur1 + ", \nNumber of legs: " + NoOfLegs1;
        //}
    }
}
