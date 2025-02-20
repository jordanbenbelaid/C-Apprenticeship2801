using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsInstructor
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException() : base("Age must be greater than 16")
        { 
        
        }

        public InvalidAgeException(string msg) : base(msg)
        {

        }
    }
}
