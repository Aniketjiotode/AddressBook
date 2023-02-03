using System;

namespace Address_Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook");
            AddressBook address = new AddressBook();
            while (true)
            {
                Console.WriteLine("Enter 1 to Add a new contact \n Enter 2 to Diplay all Contacts");
                int result = int.Parse(Console.ReadLine());

                switch (result)
                {
                    case 1: address.AddToContact(); break;
                    case 2: address.Display(); break;
                }
            }
        }
    }
}
