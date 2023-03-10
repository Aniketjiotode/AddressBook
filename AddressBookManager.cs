using Address_Book;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AddressBookSystem
{
    public class AddressBookManager
    {
        List<AddressBook> Addresses;
        public AddressBookManager()
        {
            Addresses = new List<AddressBook>();
        }
        public void Open_AddressBook()
        {
            Console.WriteLine("Enter AddressBook Name:");
            string book_name = Console.ReadLine();
            AddressBook Address_book = null;
            foreach (var res in Addresses)
            {
                if (res.AddressBook_Name==book_name)
                {
                    Address_book = res;
                    AddressBook_operation(Address_book);
                    return;
                }
            }
            Console.WriteLine("there is no addressBook with entered name");
        }
        public void Create_AddressBook()
        {
            Console.WriteLine("Enter AddressBook Name:");
            string name = Console.ReadLine();
            Addresses.Add(new AddressBook(name));
            return;
        }
        public void AddressBook_operation(AddressBook addressBook)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter A to Add new contact\nEnter E to edit a contact\nEnter D to Delete a Contact\nEnter P to print the contacts");
                char ch = Console.ReadLine().ToUpper()[0];
                switch (ch)
                {
                    case 'A':
                        addressBook.AddToContact();
                        break;
                    case 'E':
                        addressBook.EditContact();
                        break;
                    case 'D':
                        addressBook.DeleteContact();
                        break;
                    case 'P':
                        addressBook.Display();
                        break;
                    default:
                        break;
                }
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("Enter 'BACK' to go back to AddressBookManagement  or 'No' to stay in current addressBook :");
                string input = Console.ReadLine().ToUpper();
                if (input.Equals("BACK"))
                {
                    flag = false;
                }
            }
        }
      
        
    }
}