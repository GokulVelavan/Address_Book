using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Globalization;
using CsvHelper;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Address_Book
{
    class AddressBookCSV
    {
        List<ContactList> contactDetails = new List<ContactList>();
        ContactList contact = new ContactList();
        public void WriteDataInCSVFile()
        {
            contact.firstName = "Gokul";
            contact.lastName = "Velavan";
            contact.address = "******";
            contact.city = "kanyakumari";
            contact.state = "Tamilnadu";
            contact.zipCode = "64589794";
            contact.phoneNumber = "23156565555";
            contact.email = "gokul@gmail.com";

            contactDetails.Add(contact);

            string path = @"C:\Users\INFINITY\source\repos\Address_Book\AddressBookFileCSV.csv";

            using (var streamWriter = new StreamWriter(path))
            {
                using (var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture))
                {
                    csvWriter.WriteRecords(contactDetails);
                }
             }
          
        }

        public void ReadeDataInCSVFile()
        {
            string path = @"C:\Users\INFINITY\source\repos\Address_Book\AddressBookFileCSV.csv";


            using (var reader = new StreamReader(path))
            using (var csvRead = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var output = csvRead.GetRecords<ContactList>().ToList();
                foreach (ContactList details in output)
                {
                    Console.WriteLine("FirstName: {0}\tLastName: {1}\tAddress: {2}\tCity: {3}\tState: {4}\tZipCode: {5}\tPhoneNumber: {6}\tEmail: {7}", details.firstName, details.lastName, details.address, details.city, details.state, details.zipCode, details.phoneNumber, details.email);
              

                }
            }

        }

    }
}
