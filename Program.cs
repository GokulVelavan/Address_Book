using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book.");
           AddressBook obj1 = new AddressBook(); //creating object
           obj1.getContactDetails();//adding data
            obj1.printDetails(); //printing data
            Console.ReadLine();

        }
    }
}
