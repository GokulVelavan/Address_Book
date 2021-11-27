using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using System.Globalization;
using CsvHelper;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Address_Book
{
    class AddressBookJSON
    {
       
        public void ReadingandWritingJson()
        {
            
            string path = @"C:\Users\INFINITY\source\repos\Address_Book\AddressBookFileCSV.csv";


            var reader = new StreamReader(path);
            var csvRead = new CsvReader(reader, CultureInfo.InvariantCulture);
            var output = csvRead.GetRecords<ContactList>().ToList();
            foreach (ContactList details in output)
            {
                Console.WriteLine("FirstName: {0}\tLastName: {1}\tAddress: {2}\tCity: {3}\tState: {4}\tZipCode: {5}\tPhoneNumber: {6}\tEmail: {7}", details.firstName, details.lastName, details.address, details.city, details.state, details.zipCode, details.phoneNumber, details.email);
            }

            string JSONpath = @"C:\Users\INFINITY\source\repos\Address_Book\AddressBookFileJSON.json";

            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(JSONpath))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, output);
            }
        }
    }
}
