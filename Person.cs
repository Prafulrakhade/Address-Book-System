using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace AddressBookSystem
{
    internal class Person
    {
        public string First_Name;
        public string Last_Name;
        public string Address;
        public string City;
        public string State;
        public long Zip_Code;
        public long Phone_Number;
        public string Email_ID;

        public string Result()
        {
            return "First Name: " + First_Name + "\n Last name: " + Last_Name + "\n Address: " + Address + "\n City: " + City + 
            "\n State:" + State + "\n Zop COde: " + Zip_Code + "\n Phone Number: " + Phone_Number + "Email ID: " + Email_ID;
        }
    }

    internal class AddressBook
    {

        public List<Person> person = new List<Person>();

        public void Display()
        {
            foreach (Person per in person)
            {
                Console.WriteLine(per.Result());
            }
        }

        public void AddPerson(Person p)
        {
            person.Add(p);
            string jsonData = JsonConvert.SerializeObject(person);
            File.WriteAllText(@"C:\Users\HP\BridgeLabzs\Assignment\Day-10\AddressBookSystem\AddressBookSystem\AddressBookResult.json", jsonData);
        }
    }
}
