using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addressbook
{
    public interface IContact
    {
        public void CreateContact(string firstName, string lastName, string address, string city, string state, string email, int zip, long phoneNumber,string BookName);
        public void ViewContact(string Name, string BookName);
        public void EditContact(string Name, string BookName);
        public void DeleteContact(string Name, string BookName);
        public void AddAddressBook(string BookName);
    }
}
