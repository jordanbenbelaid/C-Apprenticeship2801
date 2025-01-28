namespace ApprenticeshipDemo
{
    public class Person
    {
        //attributes of a person
        private int Age;
        private string Name;
        private string Email;
        //this static counter belongs to the Person class
        //so anytime a person object is created, the counter increases by 1
        public static int Counter = 0;


        //constructor
        public Person(int Age, string Name, string Email)
        {
            this.Age = Age;
            this.Name = Name;
            this.Email = Email;
            //increase the counter by 1 when this constructor is used
            Counter++;
        }

        //increase the counter by 1 when this constructor is used
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
