using Json.NetSample.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json.NetSample
{
    class Program
    {
        private static string _path = @"C:\Json Sample\Contacts.json";
        static void Main(string[] args)
        {
            var contacts = GetContacts();

        }
        public static void SerializeJsonFile (List<Contact> contacts)
        {
            string contactsJson = JsonConvert.SerializeObject(contacts.ToArray(), Formatting.Indented);
            File.WriteAllText(
        }
        public static List<Contact> GetContacts()
        {

            List<Contact> contacts = new List<Contact>{

                new Contact
                {
                    Name = "John Wick",
                    DateOfBirth = new DateTime(1980, 05, 17),
                    Address = new Address{
                        Street= "Centennial Dr",
                        Number = 15,
                        City = new City {
                            Name="Chicago",
                            Country = new Country { Code = "USA", Name = "United States" }

                        }
                    },
                    Phones = new List<Phone>{
                        new Phone { name = "Personal", Number = "8092563214"},
                        new Phone { name = "Work", Number = "8526547898"}
                    }
                },
                new Contact
                {
                    Name = "Briana Minaya",
                    DateOfBirth = new DateTime(2000, 08, 01),
                    Address = new Address{
                        Street= "Washington Ave",
                        Number = 201,
                        City = new City {
                            Name="New York",
                            Country = new Country { Code = "USA", Name = "United States" }

                        }
                    },
                    Phones = new List<Phone>{
                        new Phone { name = "Personal", Number = "8092563214"},
                        new Phone { name = "Work", Number = "8526547898"}
                    }

                },
                new Contact
                {
                    Name = "Julio Fuerte",
                    DateOfBirth = new DateTime(2001, 10, 26),
                    Address = new Address{
                        Street= "Calle del Monte y Tejada",
                        Number = 22,
                        City = new City {
                            Name="San Cristobal",
                            Country = new Country { Code = "DR", Name = "Republica Dominicana" }

                        }
                    },
                    Phones = new List<Phone>{
                        new Phone { name = "Personal", Number = "1234567456"},
                        new Phone { name = "Work", Number = "36985214710"}
                    }
                }

            };

                return null;

        }
    }
}

