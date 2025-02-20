using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsInstructor
{
    public class Demo
    {

        public static void ValidateAge(int age)
        {
            if(age < 16)
            {
                throw new InvalidAgeException("Your age is less than appropriate");
            }
            else
            {
                Console.WriteLine("You are old enough to proceed");
            }
        }
    }
}
