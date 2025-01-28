namespace ApprenticeshipDemo
{
    public class Person
    {
        //attributes of a person
        private int Age;
        private string Name;
        private string Email;
        public static int Counter = 0;


        //constructor
        public Person(int Age, string Name, string Email)
        {
            this.Age = Age;
            this.Name = Name;
            this.Email = Email;
            Counter++;
        }

        public Person() { Counter++; }


        //getters and setters

        public int GetAge()
        {
            return this.Age;
        }

        public void SetAge(int Age)
        {
            this.Age = Age;
        }

        //methods

        public static string Walk()
        {
            return "I am walking";
        }

        //ToString
        public override string ToString()
        {
            return "Person - Name: " + Name + ", Age: " + Age + ", Email: " + Email;
        }

        
    }
}
