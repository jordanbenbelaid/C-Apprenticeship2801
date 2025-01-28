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

        Console.WriteLine(Person.Counter);

        Console.WriteLine(Person.Walk());

        Console.WriteLine(Jordan.GetAge());

        Jordan.SetAge(25);

        Console.WriteLine(Jordan.GetAge());

        Console.WriteLine(Jordan);


    }




}
