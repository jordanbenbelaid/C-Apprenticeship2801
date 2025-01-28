using System.Collections;

namespace ApprenticeshipDemo;

public class Program
{
    public static void Main(string[] args)
    {
        Person Jordan = new Person(27, "Jordan", "Jordan@hotmail.com");
        Person P = new Person();
        Person Pe = new Person();

        //Console.WriteLine(Jordan.Walk());

        //we directly call the Person class, and because we want the count of each person created
        //we use the dot walking to access the Counter attribute which is static
        Console.WriteLine(Person.Counter);

        //because we made the Walk method in the Person class static, we dont have to use the
        //object, but we can just use the class name and call the Walk method this way instead
        Console.WriteLine(Person.Walk());

        Console.WriteLine(Jordan.GetAge());

        Jordan.SetAge(25);

        Console.WriteLine(Jordan.GetAge());

        Console.WriteLine(Jordan);


    }




}
