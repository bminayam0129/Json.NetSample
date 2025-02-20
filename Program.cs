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
        private static string _path = @"C:\JsonSample\Contacts.json";
        static void Main(string[] args)
        {
            //var contacts = GetContacts();
            //SerializeJsonFile(contacts);

            var contacts = GetContactsJsonFromFile();
            //DeserializeJsonFile(contacts);

            ReadingJsonWithJSONTextReader(contacts);
        }

        public static void SerializeJsonFile(List<Contact> contacts)
        {
            string contactsJson = JsonConvert.SerializeObject(contacts.ToArray(), Formatting.Indented);
            File.WriteAllText(_path, contactsJson);
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

        public static string GetContactsJsonFromFile()
        {
            string contactsJsonFromFile;
            using (var reader = new StreamReader(_path))
            {
                contactsJsonFromFile = reader.ReadToEnd();
            }
            return contactsJsonFromFile;
        }
        public static void DeserializeJsonFile(string contactsJsonFromFIle)
        {
            Console.WriteLine(contactsJsonFromFIle);

            var contacts = JsonConvert.DeserializeObject<Contact>(contactsJsonFromFIle);

            Console.WriteLine(string.Format("Briana Minaya's Address is: {0} {1}",
                contacts[0].Address.Street, contacts[0].Address.Number));
            Console.WriteLine(string.Format("Briana Minaya's Date of birth is on is: {0} {1}",
               contacts[0].DateOfBirth.ToShortDateString()));
        }
        public static void ReadingJsonWithJSONTextReader(string contactsJsonFromFile)
        {
            JsontTextReader reader = new JsonTextReader(new StringReader(contactsJsonFromFile));

            while (reader.Read())
            {
                if (reader.Value != null)
                {
                    Console.WriteLine("Token: {0}, Vakue: {1}", reader.TokenType, reader.Value);
                }
                else
                {
                    Console.WriteLine("Token: {0}", reader.TokenType);
                }
            }
        }
    }
}
