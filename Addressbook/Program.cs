using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Addressbook
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            AddressBook addressBook = new AddressBook("Akshay","Patil","AntorePhata","Pen","Maharashtra","akshaypatil309p8@gamil.com",402107,98587456985);
            addressBook.DisplayContatcs();
        }
    }
}