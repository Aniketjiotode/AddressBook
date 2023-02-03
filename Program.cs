using System;

namespace Address_Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To AddressBook");
            AddressBook address = new AddressBook();
            while (true)
            {
                Console.WriteLine("Enter 1 to Add a new contact \n Enter 2 to Diplay all Contacts \n Enter 3 to Diplay Edit Contacts \n Enter 4 to Delete Contacts");
                int result = int.Parse(Console.ReadLine());
                switch (result)
                {
                    case 1: address.AddToContact(); break;
                    case 2: address.Display(); break;
                    case 3: address.EditContact(); break;
                    case 4: address.DeleteContact(); break;
                }
            }
        }
    }
}
