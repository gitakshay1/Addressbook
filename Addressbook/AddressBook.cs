using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addressbook
{
    public class AddressBook
    {
        public string FirstName, LastName, Address, City, State,Email;
        public int Zip;
        public long PhoneNumber;
        public AddressBook[] ContactArray;
        public int Contact = 0;
        public AddressBook()
        {
            this.ContactArray= new AddressBook[10];
        }
        public AddressBook(string firstName, string lastName, string address, string city, string state,string email, int zip, long phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            Email = email;
            Zip = zip;
            PhoneNumber = phoneNumber;
        }
        public void CreateContact(string firstName, string lastName, string address, string city, string state, string email, int zip, long phoneNumber)
        {
            ContactArray[this.Contact]=new AddressBook(firstName,lastName,address,city,state,email,zip,phoneNumber);
            Contact++;
            Program program=new Program();
            program.DisplayContatcs(ContactArray, Contact);
        }
        public void EditContact()
        {
            int i = 0;
            Console.WriteLine("Enter First Name to Edit");
            string FirstName=Console.ReadLine();
            while (ContactArray[i].FirstName!=FirstName)
            {
                i++;

            }
            Console.WriteLine("Enter Field tobe Modify\n1.First Name\n2.Last Name\n3.Address\n4.city\n5.State\n6.Email\n7.Zip\n8.Phone Number");
            int Option =Convert.ToInt32(Console.ReadLine());
            switch(Option)
            {
                case 1:
                    Console.WriteLine("Enter Modified Value");
                    string FName= Console.ReadLine();
                    ContactArray[i].FirstName = FName;
                    break;
                case 2:
                    Console.WriteLine("Enter Modified Value");
                    string LName = Console.ReadLine();
                    ContactArray[i].LastName = LName;
                    break;
                case 3:
                    Console.WriteLine("Enter Modified Value");
                    string Addres = Console.ReadLine();
                    ContactArray[i].Address = Addres;
                    break;
                case 4:
                    Console.WriteLine("Enter Modified Value");
                    string citi = Console.ReadLine();
                    ContactArray[i].City = citi;
                    break;
                case 5:
                    Console.WriteLine("Enter Modified Value");
                    string stat = Console.ReadLine();
                    ContactArray[i].State = stat;
                    break;
                case 6:
                    Console.WriteLine("Enter Modified Value");
                    string emai = Console.ReadLine();
                    ContactArray[i].Email = emai;
                    break;
                case 7:
                    Console.WriteLine("Enter Modified Value");
                    int zi = Convert.ToInt32(Console.ReadLine());
                    ContactArray[i].Zip = zi;
                    break;
                case 8:
                    Console.WriteLine("Enter Modified Value");
                    int mNumber = Convert.ToInt32(Console.ReadLine());
                    ContactArray[i].PhoneNumber = mNumber;
                    break;
            }
            Program pr=new Program();
            pr.DisplayContatcs(ContactArray, Contact);

        }
        public void DeleteContact()
        {
            Console.WriteLine("Enter First Name to Delete Contact");
            string FirstName = Console.ReadLine();
            int index = -1;
            for(int i = 0; i < Contact; i++)
            {
                if (ContactArray[i].FirstName == FirstName)
                {
                    index = i;
                    break;
                }
            }
            if(index != -1)
            {
                for(int i = index; i < Contact - 1;i++)
                {
                    ContactArray[i] = ContactArray[i + 1];
                }
                Contact--;
                Console.WriteLine("Contact is Deleted");
            }
            else
            {
                Console.WriteLine("Contact is not present");
            }
            Program pro= new Program();
            pro.DisplayContatcs(ContactArray,Contact);
        }
        
    }
}
