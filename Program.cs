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
            int n;
            Console.WriteLine("Welcome to Address Book.");
            AddressBook obj1 = new AddressBook(); //creating object
            Console.WriteLine("Please enter how many contact you want to add");
             n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                obj1.getContactDetails();
                Console.WriteLine("\n");    

            }


            obj1.printDetails(); //printing data

            Console.ReadLine();

        }
    }
}
