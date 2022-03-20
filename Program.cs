using System;

namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------- WELCOME TO THE ADDRESS BOOK PROGRAM -----------------");
            Console.WriteLine();
            Console.WriteLine();

            AddressBook add = new AddressBook();
            Person person = new Person();
            person.First_Name = "PRAFUL";
            person.Last_Name = "RAKHADE";
            person.Address = "WARD NO.2 NEAR RAJESH MEDICAL KHAT";
            person.City = "NAGPUR";
            person.State = "MAHARASHTRA";
            person.Zip_Code = 441106;
            person.Phone_Number = 7038008002;
            person.Email_ID = "prafulrakhade02@gmail.com";
            add.AddPerson(person);
            add.Display();
        }
    }
}
