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
        string Name;
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

        public void editContactDetails(int i)   // getting details from the person
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

            //Editing the contact details by the index
            Contact[i++] = firstName;
            Contact[i++] = (lastName);
            Contact[i++] = (address[0]);
            Contact[i++] = (state);
            Contact[i++] = (zipCode);
            Contact[i++] = (phoneNumber);
            Contact[i] = (email);

        }
        public void deleteContactDetails(int i)
        {

            for(int j=0;j<7;j++)
            {
                for(int k=i;k<Contact.Count-1;k++)
                Contact[k] = Contact[k + 1];//ovverriding the contact
            }

            for(int j=Contact.Count-7;j<=Contact.Count;j++)
            {
                Contact.RemoveAt(j); //removing the last dublicate value
            }

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

        public void editContact() //Program to edit contact
        {
            Console.WriteLine("Please enter the Name you want to edit :\n");
             Name = Console.ReadLine();//getting name

            if (Contact.Contains(Name))//check the name present or not
            {

                int  i=Contact.IndexOf(Name); ///finding the index of the name
                     editContactDetails(i); //passing the index to change the value
            }
            else
            {
                Console.WriteLine("Sorry We dont have that user");
            }

        }

        public void removeContact()
        {
            Console.WriteLine("Please enter the Name you want to delete :\n");
            Name = Console.ReadLine();//getting name
            if (Contact.Contains(Name))//check the name present or not
            {
                int i = Contact.IndexOf(Name); ///finding the index of the name
                deleteContactDetails(i); //passing the index to change the value
            }
            else
            {
                Console.WriteLine("Sorry We dont have that user");
            }

        }
        }
}
