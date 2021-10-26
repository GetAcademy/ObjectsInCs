namespace ObjectsInCs
{
    class Address
    {
        public string StreetName;
        public string StreetNo;
        public string PostCode;
        public string City;

        public Address()
        {
        }

        public Address(string streetName, string streetNo, string postCode, string city)
        {
            StreetName = streetName;
            StreetNo = streetNo;
            PostCode = postCode;
            City = city;
        }
    }
}
