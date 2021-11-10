using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Address_Book
{
    class AddressBook
    {

        string firstName;
        string lastName;
        string[] address = new string[2];
        string state;
        int zipCode;
        long phoneNumber;
        string email;
        
        public void getContactDetails()   // getting details from the person
        {

            Console.WriteLine("Enter the First Name");
            firstName = Console.ReadLine();

            Console.WriteLine("Enter the Last Name");
            lastName = Console.ReadLine();

            Console.WriteLine("Enter the Adresss");
            address[0] = Console.ReadLine();


            Console.WriteLine("Enter the State");
            state = Console.ReadLine();

            Console.WriteLine("Enter the Zip Code");
            zipCode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Phone Number");
            phoneNumber = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Enter the Email");
            email = Console.ReadLine();


        }

        public void printDetails() // Printing contact details
        {
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);
            Console.WriteLine("Address: " + address[0]);
            Console.WriteLine("state: " + state);
            Console.WriteLine("Zip Code: " + zipCode);
            Console.WriteLine("Phone NUmber: " + phoneNumber);
            Console.WriteLine("Email: " + email);




        }
    }
}
