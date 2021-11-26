using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Address_Book
{
    internal class ContactList
    {
        public string firstName;
        public string lastName;
        public string[] address = new string[2];
        public string city;
        public string state;
        public int zipCode;
        public long phoneNumber;
        public string email;


        public ContactList(string firstName, string lastName, string[] address,string city, string state, int zipCode, long phoneNumber, string email)
        {

            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipCode = zipCode;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }
    }

    class AddressBook
    {

        string firstName;
        string lastName;
        string[] address = new string[2];
        string city;
        string state;
        int zipCode;
        long phoneNumber;
        string email;
        string Name;


        private List<ContactList> addressBook = new List<ContactList>();//to store data
        public Dictionary<string, string> addressBookCity = new Dictionary<string, string>(); //to store address by city
        public Dictionary<string, string> addressBookState = new Dictionary<string, string>(); //to store address by state 
        public void getContactDetails()   // getting details from the person
        {

            Console.WriteLine("Enter the First Name");
            firstName = Console.ReadLine();

            Console.WriteLine("Enter the Last Name");
            lastName = Console.ReadLine();

            Console.WriteLine("Enter the Adresss");
            address[0] = Console.ReadLine();


            Console.WriteLine("Enter the city");
            city = Console.ReadLine();

            Console.WriteLine("Enter the State");
            state = Console.ReadLine();

            Console.WriteLine("Enter the Zip Code");
            zipCode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Phone Number");
            phoneNumber = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Enter the Email");
            email = Console.ReadLine();

            //Adding the contact details in array

            bool flag = true;

            foreach (ContactList contactList in this.addressBook)
            {
                if (contactList.firstName == firstName)
                {
                    flag = false;
                }
            }

            if (flag)
            {
                ContactList contactList = new ContactList(firstName, lastName, address, city, state, zipCode, phoneNumber, email);
                this.addressBook.Add(contactList);
            }
            else
            {
                Console.WriteLine("data is already present.");
            }

        }


        public void printDetails() // Printing contact details
        {

            foreach (ContactList contactList in this.addressBook)
            {
                Console.WriteLine($"FirstName= {contactList.firstName} LastName= {contactList.lastName} Address= {contactList.address} city={contactList.city} state= {contactList.state} ZipCode= {contactList.zipCode} Phone= {contactList.phoneNumber} Email= {contactList.email}");

            }

        }

        public void editContact() //Program to edit contact
        {
            Console.WriteLine("Enter the name ");
            string name = Console.ReadLine();
            bool FLAG = true;
            foreach (ContactList contactList in this.addressBook)
            {

                if (contactList.firstName == name)
                {
                    Console.WriteLine($"FirstName= {contactList.firstName} LastName= {contactList.lastName} Address= {contactList.address} city={contactList.city} state= {contactList.state} ZipCode= {contactList.zipCode} Phone= {contactList.phoneNumber} Email= {contactList.email}");
                    Console.WriteLine("\nthe {0} is present you can edit the details...", contactList.firstName);
                    Console.WriteLine("enter the details");

                    Console.WriteLine("Enter the First Name");
                    contactList.firstName = Console.ReadLine();

                    Console.WriteLine("Enter the Last Name");
                    contactList.lastName = Console.ReadLine();

                    Console.WriteLine("Enter the Adresss");
                    contactList.address[0] = Console.ReadLine();

                    Console.WriteLine("Enter the city");
                    contactList.city = Console.ReadLine();

                    Console.WriteLine("Enter the State");
                    contactList.state = Console.ReadLine();

                    Console.WriteLine("Enter the Zip Code");
                    contactList.zipCode = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the Phone Number");
                    contactList.phoneNumber = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Enter the Email");
                    contactList.email = Console.ReadLine();

                    Console.WriteLine("updeted detalis List");
                    FLAG = false;
                }

            }
            if (FLAG)
            {
                Console.WriteLine("sorry we dont have that contact");

            }
        }

        public void removeContact()
        {
            Console.WriteLine("Please enter the Name you want to delete :\n");
            Name = Console.ReadLine();//getting name
            bool FLAG = true;

            foreach (ContactList contactList in this.addressBook)
            {

                if (contactList.firstName == Name)
                {
                    addressBook.Remove(contactList);
                    break;
                    FLAG = false;

                }
            }
            if (FLAG)
            {
                Console.WriteLine("sorry we dont have that contact");

            }
        }
        public void SearchPersonBYCity()//search person by city
        {
            Console.WriteLine("\nEnter City Name to search person with city");
            string cityName = Console.ReadLine();
            foreach (ContactList contactList in this.addressBook)
            {

                if (contactList.city == city)
                {
                    Console.WriteLine($"FirstName= {contactList.firstName} LastName= {contactList.lastName} Address= {contactList.address} city={contactList.city} state= {contactList.state} ZipCode= {contactList.zipCode} Phone= {contactList.phoneNumber} Email= {contactList.email}");

                    addressBookCity.Add(cityName, contactList.firstName);
                }
            }
        }

        public void searchPersonbyState()
        {
            Console.WriteLine("\nEnter State Name");
            string stateName = Console.ReadLine();
            foreach (ContactList contactList in this.addressBook)
            {

                if (contactList.state == stateName)
                {
                    Console.WriteLine($"FirstName= {contactList.firstName} LastName= {contactList.lastName} Address= {contactList.address} city={contactList.city} state= {contactList.state} ZipCode= {contactList.zipCode} Phone= {contactList.phoneNumber} Email= {contactList.email}");
                    addressBookState.Add(stateName, contactList.firstName);
                }
            }
        }

        public void getcount()
        {
            int count1 = 0, count2 = 0;
            Console.WriteLine("\nEnter City name");
            string city = Console.ReadLine();

            Console.WriteLine("\nEnter Sate Name");
            string state = Console.ReadLine();

            foreach (ContactList contactList in this.addressBook)
            {

                if (contactList.state == state)
                {
                    count1++;
                }
                if (contactList.city == city)
                {
                    count2++;
                }
            }
            Console.WriteLine("\nCount by state: " + count1);

            Console.WriteLine("\nCount by city: " + count2);
        }

        public void SortByName()
        {
            addressBook = addressBook.OrderBy(p => p.firstName).ToList();
        }

        public void SortByData()
        {
            Console.WriteLine("Enter the number to sort BY. 1-City, 2- State, 3- Zip");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 1)
            {
                addressBook = addressBook.OrderBy(p => p.city).ToList();
            }
            else if (n == 2)
            {
                addressBook = addressBook.OrderBy(p => p.state).ToList();
            }
            else if (n == 3)
            {
                addressBook = addressBook.OrderBy(p => p.zipCode).ToList();
            }
          
        }

    }
}
