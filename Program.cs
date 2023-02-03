using AddressBookSystem;
using System;
using System.Threading;

namespace Address_Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To AddressBook");
            AddressBookManager manager = new AddressBookManager();
            while (true)
            {
                Console.WriteLine("Enter O to open an AddressBook\nEnter C to create an AddressBook");
                char input = Console.ReadLine().ToUpper()[0];
                switch (input)
                {
                    case 'O':
                        manager.Open_AddressBook();
                        break;
                    case 'C':
                        manager.Create_AddressBook();
                        break;
                    default:
                        Console.WriteLine("Invalid Entry try again");
                        break;
                }
                Thread.Sleep(4000);
                Console.Clear();
            }
        }
    }
}
