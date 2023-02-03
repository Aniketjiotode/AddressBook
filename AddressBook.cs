using System;
using System.Collections.Generic;
using System.Text;

namespace Address_Book
{
    public class AddressBook
    {
        public List<Contact> contacts;
        public AddressBook()
        { 
            contacts = new List<Contact>();
        }
        public void AddToContact()
        {
            var contact = new Contact();
            Console.WriteLine("Enter FirstName:");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter LastName:");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter Address");
            contact.Address =Console.ReadLine();
            Console.WriteLine("Enter City");
            contact.City =Console.ReadLine();
            Console.WriteLine("Enter State");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter Email Id");
            contact.Email = Console.ReadLine();
            Console.WriteLine("Enter Zipcode");
            contact.ZipCode = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Phone Number");
            contact.PhoneNumber = int.Parse(Console.ReadLine());
            contacts.Add(contact);
        }
        public void Display()
        {
            if (contacts.Count <= 0)
            {
               Console.WriteLine("No contacts available");
            }
            else
            {
                foreach (var contact in contacts)
                {
                    Console.WriteLine("FirstName: " + contact.FirstName + "\n LastName:" + contact.LastName + "\n Address: " + contact.Address + "\n City: "+contact.City + "\n State: "+contact.State + "\n Email Id"+contact.Email + "\n ZipCode: "+contact.ZipCode + "\n Phone number: "+contact.PhoneNumber);
                }
            }
        }
    }
}
