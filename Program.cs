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
            bool decide = true;
            int n;
            Console.WriteLine("Welcome to Address Book.");
            AddressBook obj1 = new AddressBook(); //creating object

            Dictionary<string, AddressBook> addressBook_Dictionary = new Dictionary<string,AddressBook>();
            while (decide)
            {

                Console.WriteLine("1.AddNewContact\n2.PrintContact\n3.EditContact\n4.DeleteContact\n5.Search by City\n6.Search by state\n7.getcount by city or state\n8.Exit");
                Console.WriteLine("\nPlease Enter your choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {

                    case 1:
                        Console.WriteLine("Please enter how many contact you want to add:");
                        n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            obj1.getContactDetails();
                            Console.WriteLine("\n");

                        }
                        break;
                    case 2:
                obj1.printDetails(); //printing data
                        break;
                    case 3:
                        obj1.editContact();//edit contact details
                        break;

                    case 4:
                        obj1.removeContact(); //remove contact details
                        break;


                    case 5:
                        obj1.SearchPersonBYCity();//search by city
                        break;
                    case 6:
                        obj1.searchPersonbyState();//search by state
                        break;
                    case 7:
                        obj1.getcount();//get count person by city and state
                        break;
                    case 8:
                        decide = false;//code to exit the loop
                        break;
                    default:
                        Console.WriteLine("Please Enter The Valid Data");
                        break;
                }
            }
            Console.WriteLine("\nEnter Address Book Name:");
            string name = Console.ReadLine(); //name of address book
            addressBook_Dictionary.Add(name,obj1);
            foreach (var data in addressBook_Dictionary)
            {
                Console.WriteLine(data.Value);
            }

            Console.ReadLine();

        }
    }
}
