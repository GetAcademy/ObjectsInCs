namespace ObjectsInCs
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public Address Address;
        public Employer Employer;

        public Person()
        {
        }

        public Person(string firstName, string lastName, int age, Address address, Employer employer)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Address = address;
            Employer = employer;
        }
    }
}
