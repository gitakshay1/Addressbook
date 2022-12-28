using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
namespace Addressbook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            //AddressBook addressBook = new AddressBook("Akshay","Patil","AntorePhata","Pen","Maharashtra","akshaypatil309p8@gamil.com",402107,98587456985);
            //addressBook.DisplayContatcs();
            AddressBook add= new AddressBook();
            Console.WriteLine("Enter Number of Contact to Add");
            int Contact=Convert.ToInt32(Console.ReadLine());
            while(Contact>0)
            {
                Console.WriteLine("Enter First Name");
                string FirstName= Console.ReadLine();
                Console.WriteLine("Enter Last Name ");
                string LastName= Console.ReadLine();
                Console.WriteLine("Enter Address");
                string Address = Console.ReadLine();
                Console.WriteLine("Enter City ");
                string City = Console.ReadLine();
                Console.WriteLine("Enter State ");
                string State = Console.ReadLine();
                Console.WriteLine("Enter Email");
                string Email= Console.ReadLine();
                Console.WriteLine("Enter Zip");
                int Zip= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Phone Number");
                long PhoneNumber= Convert.ToInt64(Console.ReadLine());
                add.CreateContact(FirstName,LastName,Address,City, State, Email, Zip, PhoneNumber);
                Contact--;
            }
            Console.WriteLine("Do you want to modify(Y/N)");
            Char Ch=Convert.ToChar(Console.ReadLine());
            if(Ch=='Y' || Ch=='y')
            {
                add.EditContact();
            }
        }
        public void DisplayContatcs(AddressBook[] ContactArray,int n)
        {
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("Name : {0} {1}",ContactArray[i].FirstName, ContactArray[i].LastName);
                Console.WriteLine("Address : {0}", ContactArray[i].Address);
                Console.WriteLine("City : {0}", ContactArray[i].City);
                Console.WriteLine("State : {0}", ContactArray[i].State);
                Console.WriteLine("Email : {0}", ContactArray[i].Email);
                Console.WriteLine("Zip : {0}", ContactArray[i].Zip);
                Console.WriteLine("PhoneNumber : {0}", ContactArray[i].PhoneNumber);
            }
            
        }
    }
}