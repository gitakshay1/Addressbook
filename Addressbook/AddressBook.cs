using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Addressbook
{
    public class AddressBook :IContact
    {
        public Dictionary<string, Contact> addressbook = new Dictionary<string, Contact>();
        public Dictionary<string, AddressBook> addressbookDictionary = new Dictionary<string, AddressBook>();
        public void CreateContact(string firstName, string lastName, string address, string city, string state, string email, int zip, long phoneNumber, string BookName)
        {
            Contact contact = new Contact();
            contact.FirstName = firstName;
            contact.LastName = lastName;
            contact.Address = address;
            contact.City = city;
            contact.State = state;
            contact.Email = email;
            contact.Zip = zip;
            contact.PhoneNumber = phoneNumber;
            addressbookDictionary[BookName].addressbook.Add(contact.FirstName, contact);
            Console.WriteLine("Added Succcesfully");
        }
        public void ViewContact(string Name, string BookName)
        {
            foreach(KeyValuePair<string,Contact> item in addressbookDictionary[BookName].addressbook)
            {
                if(item.Key.ToLower().Equals(Name.ToLower()))
                {
                    Console.WriteLine("First Name:" + item.Value.FirstName);
                    Console.WriteLine("Last Name:" + item.Value.LastName);
                    Console.WriteLine("Address:" + item.Value.Address);
                    Console.WriteLine("City:" + item.Value.City);
                    Console.WriteLine("State:" + item.Value.State);
                    Console.WriteLine("Email:" + item.Value.Email);
                    Console.WriteLine("Zip:" + item.Value.Zip);
                    Console.WriteLine("Phone Number:" + item.Value.PhoneNumber);
                }
            }
        }
        public void ViewContact(string BookName)
        {
            foreach (KeyValuePair<string, Contact> item in addressbookDictionary[BookName].addressbook)
            {
                Console.WriteLine("First Name:" + item.Value.FirstName);
                Console.WriteLine("Last Name:" + item.Value.LastName);
                Console.WriteLine("Address:" + item.Value.Address);
                Console.WriteLine("City:" + item.Value.City);
                Console.WriteLine("State:" + item.Value.State);
                Console.WriteLine("Email:" + item.Value.Email);
                Console.WriteLine("Zip:" + item.Value.Zip);
                Console.WriteLine("Phone Number:" + item.Value.PhoneNumber);

            }
        }
        public void EditContact(string Name, string BookName)
        {
            foreach (KeyValuePair<string, Contact> item in addressbookDictionary[BookName].addressbook)
            {
                if (item.Key.Equals(Name))
                {
                    Console.WriteLine("Enter Field tobe Modify\n1.First Name\n2.Last Name\n3.Address\n4.city\n5.State\n6.Email\n7.Zip\n8.Phone Number");
                    int Option = Convert.ToInt32(Console.ReadLine());
                    switch (Option)
                    {
                        case 1:
                            Console.WriteLine("Enter Modified Value");
                            string FName = Console.ReadLine();
                            item.Value.FirstName = FName;
                            break;
                        case 2:
                            Console.WriteLine("Enter Modified Value");
                            string LName = Console.ReadLine();
                            item.Value.LastName = LName;
                            break;
                        case 3:
                            Console.WriteLine("Enter Modified Value");
                            string Addres = Console.ReadLine();
                            item.Value.Address = Addres;
                            break;
                        case 4:
                            Console.WriteLine("Enter Modified Value");
                            string citi = Console.ReadLine();
                            item.Value.City = citi;
                            break;
                        case 5:
                            Console.WriteLine("Enter Modified Value");
                            string stat = Console.ReadLine();
                            item.Value.State = stat;
                            break;
                        case 6:
                            Console.WriteLine("Enter Modified Value");
                            string emai = Console.ReadLine();
                            item.Value.Email = emai;
                            break;
                        case 7:
                            Console.WriteLine("Enter Modified Value");
                            int zi = Convert.ToInt32(Console.ReadLine());
                            item.Value.Zip = zi;
                            break;
                        case 8:
                            Console.WriteLine("Enter Modified Value");
                            int mNumber = Convert.ToInt32(Console.ReadLine());
                            item.Value.PhoneNumber = mNumber;
                            break;
                    }
                    Console.WriteLine("Edited Succesfully");

                }
            }
        }
        public void DeleteContact(string Name, string BookName)
        {
            if (addressbookDictionary[BookName].addressbook.ContainsKey(Name))
            {
                addressbookDictionary[BookName].addressbook.Remove(Name);
                Console.WriteLine("Deleted Successfully");
            }
            else
            {
                Console.WriteLine("Not found try again");
            }
        }
        public void AddAddressBook(string BookName)
        {
            AddressBook book=new AddressBook();
            addressbookDictionary.Add(BookName, book);
            Console.WriteLine("Address Book Created");
        }
        public Dictionary<string,AddressBook>GetAddressBook()
        {
            return addressbookDictionary;
        }

       
    }
}
