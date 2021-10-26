using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsInCs
{
    class Example2
    {
        void Demo()
        {
            var per = new Person
            {
                FirstName = "Per",
                LastName = "Olsen",
                Address = new Address
                {
                    StreetName = "Veien",
                    StreetNo = "17",
                    PostCode = "1234",
                    City = "Byen",
                },
                Employer = new Employer
                {
                    Name = "Bedriften AS",
                    Address = new Address
                    {
                        StreetName = "Gata",
                        StreetNo = "71",
                        PostCode = "4321",
                        City = "Byen",
                    },

                },
            };
            Console.WriteLine(per.Address.StreetName);
            Console.WriteLine(per.Employer.Address.StreetName);

            var pAddress = new Address("Veien", "17", "1234", "Byen");
            var eAddress = new Address("Gata", "71", "4321", "Byen");
            var per2 = new Person("Per", "Olsen", 18, pAddress, new Employer("Bedriften AS", eAddress));
        }


            /*
                const per = {
                    firstName: 'Per',
                    lastName: 'Olsen', 
                    address: {
                        streetName: 'Veien',
                        streetNo: '17',
                        postCode: '1234',
                        city: 'Byen',
                    },
                    employer: {
                        name: 'Bedriften AS',
                        address: {
                            streetName: 'Gata',
                            streetNo: '71',
                            postCode: '4321',
                            city: 'Byen',
                        },
                    }
                }             
             */
        }
    }
}
