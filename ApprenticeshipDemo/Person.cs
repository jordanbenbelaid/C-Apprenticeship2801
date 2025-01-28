namespace ApprenticeshipDemo
{
    public class Person
    {
        //attributes of a person
        private int Age;
        private string Name;
        private string Email;

        //constructor
        public Person(int Age, string Name, string Email)
        {
            this.Age = Age;
            this.Name = Name;
            this.Email = Email;
        }

        public Person() { }


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

        public string Walk()
        {
            return "I am walking";
        }

        public override string ToString()
        {
            return "Person - Name: " + Name + ", Age: " + Age + ", Email: " + Email;
        }


    }
}
