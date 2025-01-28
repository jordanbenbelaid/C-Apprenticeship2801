namespace UserInputDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            //this reads the users input as a string
            string Name = Console.ReadLine();
            //Console.WriteLine("Hello " + Name + ", how are you today?");
            Console.WriteLine($"Hello {Name}, how are you today?");

            Console.WriteLine("Enter your age: ");
            int Age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Hello {Name}, you are {Age} years old");


            Console.WriteLine("Enter your year of birth: ");
            if (int.TryParse(Console.ReadLine(), out int YearOfBirth))
            {
                Console.WriteLine($"You were born in {YearOfBirth}");
            } 
            else
            {
                Console.WriteLine("Thats not a valid year");
            }
        }
    }
}
