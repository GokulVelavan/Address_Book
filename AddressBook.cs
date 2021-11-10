using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

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
        ArrayList Contact = new ArrayList();
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

            //Adding the contact details in array
            Contact.Add(firstName);
            Contact.Add(lastName);
            Contact.Add(address[0]);
            Contact.Add(state);
            Contact.Add(zipCode);
            Contact.Add(phoneNumber);
            Contact.Add(email);

        }

        public void printDetails() // Printing contact details
        {

            Console.WriteLine("Contact_Details");

            for(int i=0;i<Contact.Count;i++)
            {
                Console.Write(Contact[i] + "   ");
                Console.WriteLine("\n");
            }
        }
    }
}
